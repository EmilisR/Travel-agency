using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class AddOrderForm : Form
    {
        private MainForm _mainForm;

        public AddOrderForm()
        {
            InitializeComponent();
        }

        public AddOrderForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            clientsBox.Text = "Select client...";
            offerBox.Text = "Select offer...";
            workerComboBox.Text = "Select worker...";
            monthCalendar.MinDate = monthCalendar.TodayDate;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (clientsBox.SelectedIndex == 0)
            {
                AddClientForm addClientForm = new AddClientForm(_mainForm);
                addClientForm.ShowDialog();
            }
            else
            {
                if (offerBox.SelectedIndex == 0)
                {
                    AddOfferForm addOfferForm = new AddOfferForm(_mainForm);
                    addOfferForm.ShowDialog();
                }
                else
                {
                    if (workerComboBox.SelectedIndex == 0)
                    {
                        AddWorkerForm addWorkerForm = new AddWorkerForm(_mainForm);
                        addWorkerForm.ShowDialog();
                    }
                    else
                    {
                        if (clientsBox.SelectedIndex != -1)
                        {
                            clientsBox.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            clientsBox.BackColor = Color.Salmon;
                        }
                        if (offerBox.SelectedIndex != -1)
                        {
                            offerBox.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            offerBox.BackColor = Color.Salmon;
                        }
                        if (workerComboBox.SelectedIndex != -1)
                        {
                            workerComboBox.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            workerComboBox.BackColor = Color.Salmon;
                        }
                        if (travellersAmountTrackBar.Value >= 1)
                        {
                            travellersAmountTrackBar.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            travellersAmountTrackBar.BackColor = Color.Salmon;
                        }
                        if (clientsBox.BackColor == Color.LightGreen && offerBox.BackColor == Color.LightGreen && workerComboBox.BackColor == Color.LightGreen && travellersAmountTrackBar.BackColor == Color.LightGreen)
                        {
                            using (var db = new TravelAgencyContext())
                            {
                                Worker worker = null;
                                var workerQuery = from w in db.Workers
                                                  where w.WorkerNumber == Convert.ToInt32(workerComboBox.SelectedItem.ToString().Split('.').First())
                                                  select w;
                                foreach (var item in workerQuery)
                                {
                                    worker = item;
                                }
                                Offer offer = null;
                                var offerQuery = from o in db.Offers
                                                 where o.OfferNumber == Convert.ToInt32(offerBox.SelectedItem.ToString().Split('.').First())
                                                 select o;
                                foreach (var item in offerQuery)
                                {
                                    offer = item;
                                }
                                Client client = null;
                                var clientQuery = from c in db.Clients
                                                  where c.ClientNumber == Convert.ToInt32(clientsBox.SelectedItem.ToString().Split(' ').Last().Remove(clientsBox.SelectedItem.ToString().Split(' ').Last().Length - 1))
                                                  select c;
                                foreach (var item in clientQuery)
                                {
                                    client = item;
                                }
                                Order.EmailSend += EmailSendHandler;
                                Order order = new Order(offer, client, worker, travellersAmountTrackBar.Value, monthCalendar.SelectionStart, new LogFileWritter(), new ScreenObjectInfoWritter(), emailConfirmationCheckBox.Checked ? new EmailInvoiceSender() : null);
                                worker.AssignOrderToWorker(order);
                                db.Orders.Add(order);
                                _mainForm.StartThreadQuantityUpdate();
                                Dispose();
                            }
                        }
                    }
                }
            }
        }

        private void EmailSendHandler(Order sender, EmailSendEventArgs args)
        {
            args.Logger.WriteToLog(sender, args.Date, args.EventType, args.Email);
        }

        private void ClientsBox_DropDown(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                List<string> list = db.Clients.Select(i => i.Name + " " + i.LastName + " [Client number: " + i.ClientNumber + "]").ToList();
                list.Insert(0, "Add new client...");
                clientsBox.DataSource = new BindingSource(list, null);
            }
        }

        private void OfferBox_DropDown(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                List<string> list = db.Offers.Select(i => i.OfferNumber + ". " + i.TravelDestination + ", " + i.HotelRanking + ", " + i.Feeding + ", €" + i.Price).ToList();
                list.Insert(0, "Add new offer...");
                offerBox.DataSource = new BindingSource(list, null);
            }
        }

        private void WorkerComboBox_DropDown(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                List<string> list = db.Workers.Select(i => i.WorkerNumber + ". " + i.Name + " " + i.LastName + ", " + i.Position).ToList();
                list.Insert(0, "Add new worker...");
                workerComboBox.DataSource = new BindingSource(list, null);
            }
        }

        private void TravellersAmountTrackBar_ValueChanged(object sender, EventArgs e)
        {
            travellersAmountValue.Text = travellersAmountTrackBar.Value.ToString();
        }
    }
}

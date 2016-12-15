using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class ShowObject : Form
    {
        Type type;
        MainForm _mainForm;
        public ShowObject(object dataSource, Type type, MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.type = type;
            objectBox.DataSource = dataSource;
        }

        public ShowObject(object dataSource, Type type)
        {
            InitializeComponent();
            this.type = type;
            objectBox.DataSource = dataSource;
        }

        public void ShowButton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (type.Equals(typeof(Order)) && !deleteButton.Visible && showButton.Text != "Send information to E-mail")
                {
                    if (objectBox.SelectedIndex == -1)
                    {
                        objectBox.BackColor = Color.Salmon;
                    }
                    else
                    {
                        NearestDeparturesForm ordersView = new NearestDeparturesForm(true);
                        
                        Worker worker = null;
                        int number = Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First());
                        worker = db.Workers.Where(x => x.WorkerNumber == number).First();
                        List<Order> list = db.Orders.Where(x => x.ServiceWorker.WorkerNumber == worker.WorkerNumber).ToList();
                        foreach (Order order in list)
                        {
                            if (order.IsActive())
                            {
                                string[] arr = new string[8];
                                arr[0] = order.OrderNumber.ToString();
                                arr[1] = order.TravelOffer.TravelDestination;
                                arr[2] = order.ServiceWorker.Name + " " + order.ServiceWorker.LastName;
                                arr[3] = order.OrderClient.Name + " " + order.OrderClient.LastName;
                                arr[4] = "€" + string.Format("{0:F2}", order.OrderPrice);
                                arr[5] = order.OrderRegisterDate.ToShortDateString();
                                arr[6] = order.TravelStartDate.ToShortDateString();
                                arr[7] = order.OrderClientsAmount.ToString();
                                ListViewItem itm = new ListViewItem(arr);
                                ordersView.nearestDeparturesListView.Items.Add(itm);
                            }
                        }
                        ordersView.Text = worker.Name + " " + worker.LastName + " orders";
                        ordersView.ShowDialog();
                        Dispose();
                    }
                }
                else if (objectBox.SelectedIndex != -1)
                {
                    if (!deleteButton.Visible && type.Equals(typeof(Order)))
                    {
                        SendInformationByEmailForm.SendEmailOrderHandler(this, null);
                    }
                    else if (!deleteButton.Visible && type.Equals(typeof(Client)))
                    {
                        SendInformationByEmailForm.SendEmailClientHandler(this, null);

                    }
                    else if (!deleteButton.Visible && type.Equals(typeof(Worker)))
                    {
                        MainForm.PayOutSalaryHandler(this, null);
                    }
                    else
                    {
                        if (type.Equals(typeof(Offer)))
                        {
                            Offer offer = null;
                            int number = Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First());
                            offer = db.Offers.Where(x => x.OfferNumber == number).First();
                            MessageBox.Show(offer.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (type.Equals(typeof(Order)))
                        {
                            Order order = null;
                            int number = Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First());
                            order = db.Orders.Where(x => x.OrderNumber == number).First();
                            MessageBox.Show(order.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (type.Equals(typeof(Client)))
                        {
                            Client client = null;
                            int number = Convert.ToInt32(objectBox.SelectedItem.ToString().Split(' ').Last().Remove(objectBox.SelectedItem.ToString().Split(' ').Last().Length - 1));
                            client = db.Clients.Where(x => x.ClientNumber == number).First();
                            MessageBox.Show(client.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (type.Equals(typeof(Worker)))
                        {
                            Worker worker = null;
                            int number = Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First());
                            worker = db.Workers.Where(x => x.WorkerNumber == number).First();
                            MessageBox.Show(worker.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else MessageBox.Show("Not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (objectBox.SelectedIndex != -1)
            {
                if (type.Equals(typeof(Offer)))
                {
                    int number = Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First());
                    try
                    {
                        if (DatabaseMethods.DeleteOffer(number))
                        {
                            MessageBox.Show("Offer was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _mainForm.StartThreadQuantityUpdate();
                            Dispose();
                        }
                        else MessageBox.Show("Offer was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Cannot delete because of reference to order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (type.Equals(typeof(Order)))
                {
                    int number = Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First());
                    try
                    {
                        if (DatabaseMethods.DeleteOrder(number))
                        {
                            MessageBox.Show("Order was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _mainForm.StartThreadQuantityUpdate();
                            Dispose();
                        }
                        else MessageBox.Show("Order was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Cannot delete because of reference to order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (type.Equals(typeof(Client)))
                {
                    int number = Convert.ToInt32(objectBox.SelectedItem.ToString().Split(' ').Last().Remove(objectBox.SelectedItem.ToString().Split(' ').Last().Length - 1));
                    try
                    {
                        if (DatabaseMethods.DeleteClient(number))
                        {
                            MessageBox.Show("Client was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _mainForm.StartThreadQuantityUpdate();
                            Dispose();
                        }
                        else MessageBox.Show("Client was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Cannot delete because of reference to order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (type.Equals(typeof(Worker)))
                {
                    int number = Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First());
                    try
                    {
                        if (DatabaseMethods.DeleteWorker(number))
                        {
                            MessageBox.Show("Worker was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _mainForm.StartThreadQuantityUpdate();
                            Dispose();
                        }
                        else MessageBox.Show("Worker was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (DbUpdateException)
                    {
                        MessageBox.Show("Cannot delete because of reference to order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else MessageBox.Show("Not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

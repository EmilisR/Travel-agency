using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                if (type.Equals(typeof(Offer)))
                {
                    if (objectBox.SelectedIndex == -1)
                    {
                        objectBox.BackColor = Color.Salmon;
                    }
                    else
                    {
                        NearestDeparturesForm ordersView = new NearestDeparturesForm(true);
                        Worker worker = null;
                        var query = from w in db.Workers
                                    where w.WorkerNumber == Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())
                                    select w;
                        foreach (var item in query)
                        {
                            worker = item;
                        }
                        foreach (Order order in db.Orders)
                        {
                            if (order.IsActive())
                            {
                                string[] arr = new string[7];
                                arr[0] = order.OrderNumber.ToString();
                                arr[1] = order.TravelOffer.TravelDestination;
                                arr[2] = order.OrderClient.Name + " " + order.OrderClient.LastName;
                                arr[3] = order.ServiceWorker.Name + " " + order.ServiceWorker.LastName;
                                arr[4] = "€" + string.Format("{0:F2}", order.OrderPrice);
                                arr[5] = order.OrderRegisterDate.ToShortDateString();
                                arr[6] = order.TravelStartDate.ToShortDateString();
                                ListViewItem itm = new ListViewItem(arr);
                                ordersView.nearestDeparturesListView.Items.Add(itm);
                            }
                        }
                        ordersView.ShowDialog();
                        Dispose();
                    }
                }
                else if (objectBox.SelectedIndex != -1)
                {
                    if (!deleteButton.Visible && type.Equals(typeof(Order)))
                    {
                        Task task = new Task(() => SendInformationByEmailForm.SendEmailOrderHandler(this, null));
                        task.RunSynchronously();
                    }
                    else if (!deleteButton.Visible && type.Equals(typeof(Client)))
                    {
                        Task task = new Task(() => SendInformationByEmailForm.SendEmailClientHandler(this, null));
                        task.RunSynchronously();
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
                            var offerQuery = from o in db.Offers
                                             where o.OfferNumber == Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())
                                             select o;
                            foreach (var item in offerQuery)
                            {
                                offer = item;
                            }
                            MessageBox.Show(offer.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (type.Equals(typeof(Order)))
                        {
                            Order order = null;
                            var orderQuery = from o in db.Orders
                                             where o.OrderNumber == Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())
                                             select o;
                            foreach (var item in orderQuery)
                            {
                                order = item;
                            }
                            MessageBox.Show(order.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (type.Equals(typeof(Client)))
                        {
                            Client client = null;
                            var clientQuery = from c in db.Clients
                                              where c.ClientNumber == Convert.ToInt32(objectBox.SelectedItem.ToString().Split(' ').Last().Remove(objectBox.SelectedItem.ToString().Split(' ').Last().Length - 1))
                                              select c;
                            foreach (var item in clientQuery)
                            {
                                client = item;
                            }
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
            using (var db = new TravelAgencyContext())
            {
                if (objectBox.SelectedIndex != -1)
                {
                    if (type.Equals(typeof(Offer)))
                    {
                        int size = db.Offers.Count();
                        Offer offer = null;
                        var offerQuery = from o in db.Offers
                                    where o.OfferNumber == Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())
                                    select o;
                        foreach (var item in offerQuery)
                        {
                            offer = item;
                        }
                        db.Offers.Remove(offer);
                        if (db.Offers.Count() + 1 == size)
                        {
                            MessageBox.Show("Offer was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _mainForm.StartThreadQuantityUpdate();
                            Dispose();
                        }
                        else MessageBox.Show("Offer was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (type.Equals(typeof(Order)))
                    {
                        int size = db.Orders.Count();
                        Order order = null;
                        var orderQuery = from o in db.Orders
                                         where o.OrderNumber == Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())
                                         select o;
                        foreach (var item in orderQuery)
                        {
                            order = item;
                        }
                        db.Orders.Remove(order);
                        if (db.Orders.Count() + 1 == size)
                        {
                            MessageBox.Show("Order was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _mainForm.StartThreadQuantityUpdate();
                            Dispose();
                        }
                        else MessageBox.Show("Order was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (type.Equals(typeof(Client)))
                    {
                        int size = db.Clients.Count();
                        Client client = null;
                        var clientQuery = from c in db.Clients
                                         where c.ClientNumber == Convert.ToInt32(objectBox.SelectedItem.ToString().Split(' ').Last().Remove(objectBox.SelectedItem.ToString().Split(' ').Last().Length - 1))
                                          select c;
                        foreach (var item in clientQuery)
                        {
                            client = item;
                        }
                        db.Clients.Remove(client);
                        if (db.Clients.Count() + 1 == size)
                        {
                            MessageBox.Show("Client was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _mainForm.StartThreadQuantityUpdate();
                            Dispose();
                        }
                        else MessageBox.Show("Client was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (type.Equals(typeof(Worker)))
                    {
                        int size = db.Workers.Count();
                        Worker worker = null;
                        var workerQuery = from w in db.Workers
                                          where w.WorkerNumber == Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())
                                          select w;
                        foreach (var item in workerQuery)
                        {
                            worker = item;
                        }
                        db.Workers.Remove(worker);
                        if (db.Workers.Count() + 1 == size)
                        {
                            MessageBox.Show("Worker was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _mainForm.StartThreadQuantityUpdate();
                            Dispose();
                        }
                        else MessageBox.Show("Worker was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

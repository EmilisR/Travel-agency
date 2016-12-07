using System;
using System.Collections.Generic;
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
            if (type.Equals(typeof(Offer)))
            {
                if (objectBox.SelectedIndex == -1)
                {
                    objectBox.BackColor = Color.Salmon;
                }
                else
                {
                    NearestDeparturesForm ordersView = new NearestDeparturesForm(true);
                    Worker worker = Program.allWorkers[Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())];
                    List<Order> list = worker.GetWorkerOrdersList();
                    foreach (Order order in list)
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
                        MessageBox.Show(Program.allOffers[Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())].ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (type.Equals(typeof(Order)))
                    {
                        MessageBox.Show(Program.allOrders[Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())].ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (type.Equals(typeof(Client)))
                    {
                        MessageBox.Show(Program.allClients[Convert.ToInt32(objectBox.SelectedItem.ToString().Split(' ').Last().Remove(objectBox.SelectedItem.ToString().Split(' ').Last().Length - 1))].ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (type.Equals(typeof(Worker)))
                    {
                        MessageBox.Show(Program.allWorkers[Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First())].ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else MessageBox.Show("Not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (objectBox.SelectedIndex != -1)
            {
                if (type.Equals(typeof(Offer)))
                {
                    int size = Program.allOffers.Count;
                    Program.allOffers.Remove(Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First()));
                    if (Program.allOffers.Count + 1 == size)
                    {
                        MessageBox.Show("Offer was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _mainForm.StartThreadQuantityUpdate();
                        Dispose();
                    }
                    else MessageBox.Show("Offer was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (type.Equals(typeof(Order)))
                {
                    int size = Program.allOrders.Count;
                    Program.allOrders.Remove(Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First()));
                    if (Program.allOrders.Count + 1 == size)
                    {
                        MessageBox.Show("Order was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _mainForm.StartThreadQuantityUpdate();
                        Dispose();
                    }
                    else MessageBox.Show("Order was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (type.Equals(typeof(Client)))
                {
                    int size = Program.allClients.Count;
                    Program.allClients.Remove(Convert.ToInt32(objectBox.SelectedItem.ToString().Split(' ').Last().Remove(objectBox.SelectedItem.ToString().Split(' ').Last().Length - 1)));
                    if (Program.allClients.Count + 1 == size)
                    {
                        MessageBox.Show("Client was deleted", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _mainForm.StartThreadQuantityUpdate();
                        Dispose();
                    }
                    else MessageBox.Show("Client was not deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (type.Equals(typeof(Worker)))
                {
                    int size = Program.allWorkers.Count;
                    Program.allWorkers.Remove(Convert.ToInt32(objectBox.SelectedItem.ToString().Split('.').First()));
                    if (Program.allWorkers.Count + 1 == size)
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

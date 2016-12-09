using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class SendInformationByEmailForm : Form
    {
        public SendInformationByEmailForm()
        {
            InitializeComponent();
        }

        private void AboutOrderButton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (db.Orders.Count() > 0)
                {
                    List<string> list = db.Orders.Select(i => i.OrderNumber + ". " + i.OrderClient.Name + " " + i.OrderClient.LastName + " " + i.TravelOffer.TravelDestination).ToList();
                    ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Order));
                    showObject.Text = "Show orders";
                    showObject.showButton.Text = "Send information to E-mail";
                    showObject.showButton.Size = new Size(240, 23);
                    showObject.deleteButton.Visible = false;
                    showObject.ShowDialog();
                }
                else MessageBox.Show("No orders!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SendEmailOrderHandler(ShowObject sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                Order order = null;
                var ordersQuery = from o in db.Orders
                            where o.OrderNumber == Convert.ToInt32(sender.objectBox.SelectedItem.ToString().Split('.').First())
                                  select o;
                foreach (var item in ordersQuery)
                {
                    order = item;
                }
                Task.Run(() => EmailSender.SendIt(order, order.OrderClient.Email, order.OrderRegisterDate, "Order information"));
                MessageBox.Show("E-mail sent to " + order.OrderClient.Email, "E-mail sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sender.Dispose();
            }
        }

        public static void SendEmailClientHandler(ShowObject sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                Client client = null;
                var clientsQuery = from c in db.Clients
                                  where c.ClientNumber == Convert.ToInt32(sender.objectBox.SelectedItem.ToString().Split(' ').Last().Remove(sender.objectBox.SelectedItem.ToString().Split(' ').Last().Length - 1))
                                   select c;
                foreach (var item in clientsQuery)
                {
                    client = item;
                }
                EmailSender.SendIt(client, client.Email, client.RegisterDate, "Client information");
                MessageBox.Show("E-mail sent to " + client.Email, "E-mail sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sender.Dispose();
            }
        }

        private void AboutClientButton_Click(object sender, EventArgs e)
        {
            using (var db = new TravelAgencyContext())
            {
                if (db.Clients.Count() > 0)
                {
                    List<string> list = db.Clients.Select(i => i.Name + " " + i.LastName + " [Client number: " + i.ClientNumber + "]").ToList();
                    ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Client));
                    showObject.Text = "Show clients";
                    showObject.showButton.Text = "Send information to E-mail";
                    showObject.showButton.Size = new Size(240, 23);
                    showObject.deleteButton.Visible = false;
                    showObject.ShowDialog();
                }
                else MessageBox.Show("No clients!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

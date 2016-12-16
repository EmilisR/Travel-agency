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
            List<Order> orderList = DatabaseMethods.SelectOrders();
            if (orderList.Count > 0)
            {
                List<string> list = orderList.Select(i => i.OrderNumber + ". " + DatabaseMethods.SelectClients().Where(x => x.ClientNumber == i.OrderClientNumber).First().Name + " " + DatabaseMethods.SelectClients().Where(x => x.ClientNumber == i.OrderClientNumber).First().LastName + " " + DatabaseMethods.SelectOffers().Where(x => x.OfferNumber == i.TravelOfferNumber).First().TravelDestination).ToList();
                ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Order));
                showObject.Text = "Show orders";
                showObject.showButton.Text = "Send information to E-mail";
                showObject.showButton.Size = new Size(564, 51);
                showObject.deleteButton.Visible = false;
                showObject.ShowDialog();
            }
            else MessageBox.Show("No orders!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SendEmailOrderHandler(ShowObject sender, EventArgs e)
        {
            Order order = null;
            int number = Convert.ToInt32(sender.objectBox.SelectedItem.ToString().Split('.').First());
            order = DatabaseMethods.SelectOrderFromQuery("SELECT * FROM Orders WHERE OrderNumber = '" + number.ToString() + "'");
            string email = DatabaseMethods.SelectClients().Where(x => x.ClientNumber == order.OrderClientNumber).First().Email;
            Task.Run(() => EmailSender.SendIt(order, email, order.OrderRegisterDate, "Order information"));
            MessageBox.Show("E-mail sent to " + email, "E-mail sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sender.Dispose();
        }

        public static void SendEmailClientHandler(ShowObject sender, EventArgs e)
        {
            Client client = null;
            int number = Convert.ToInt32(sender.objectBox.SelectedItem.ToString().Split(' ').Last().Remove(sender.objectBox.SelectedItem.ToString().Split(' ').Last().Length - 1));
            client = DatabaseMethods.SelectClientFromQuery("SELECT * FROM Clients WHERE ClientNumber = '" + number.ToString() + "'");
            Task.Run(() => EmailSender.SendIt(client, client.Email, client.RegisterDate, "Client information"));
            MessageBox.Show("E-mail sent to " + client.Email, "E-mail sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sender.Dispose();
        }

        private void AboutClientButton_Click(object sender, EventArgs e)
        {
            List<Client> clientList = new List<Client>();
            if (clientList.Count() > 0)
            {
                List<string> list = clientList.Select(i => i.Name + " " + i.LastName + " [Client number: " + i.ClientNumber + "]").ToList();
                ShowObject showObject = new ShowObject(new BindingSource(list, null), typeof(Client));
                showObject.Text = "Show clients";
                showObject.showButton.Text = "Send information to E-mail";
                showObject.showButton.Size = new Size(564, 51);
                showObject.deleteButton.Visible = false;
                showObject.ShowDialog();
            }
            else MessageBox.Show("No clients!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

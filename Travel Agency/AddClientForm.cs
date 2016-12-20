using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class AddClientForm : Form
    {
        private MainForm _mainForm;

        public AddClientForm()
        {
            InitializeComponent();
        }

        public AddClientForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(nameBox.Text, pattern: @"^[a-zA-ZąčęėįšųūžĄČĘĖĮŠŲŪŽ]+$"))
                nameBox.BackColor = Color.LightGreen;
            else nameBox.BackColor = Color.Salmon;

            if (Regex.IsMatch(lastNameBox.Text, pattern: @"^[a-zA-ZąčęėįšųūžĄČĘĖĮŠŲŪŽ]+$"))
                lastNameBox.BackColor = Color.LightGreen;
            else lastNameBox.BackColor = Color.Salmon;

            if (Regex.IsMatch(telNumberBox.Text, pattern: @"^(?!\s*$)[0-9]{8,14}$"))
                telNumberBox.BackColor = Color.LightGreen;
            else telNumberBox.BackColor = Color.Salmon;

            if (Regex.IsMatch(emailBox.Text, pattern: @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
                emailBox.BackColor = Color.LightGreen;
            else emailBox.BackColor = Color.Salmon;

            if (nameBox.BackColor == Color.LightGreen && lastNameBox.BackColor == Color.LightGreen && telNumberBox.BackColor == Color.LightGreen && emailBox.BackColor == Color.LightGreen)
            {
                if (DatabaseMethods.SelectClients().Select(x => x.Email).ToList().Contains(emailBox.Text)) MessageBox.Show("This email address exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Client client = new Client(nameBox.Text, lastNameBox.Text, emailBox.Text, telNumberBox.Text, new List<ILogger> { new LogFileWritter(), new ScreenObjectInfoWritter(), emailConfirmationCheckBox.Checked ? new EmailInvoiceSender() : null });
                    DatabaseMethods.InsertClient(client);
                    _mainForm.StartThreadQuantityUpdate();
                    Dispose();
                }
            }
        }
        private void EmailSendHandler(Client sender, EmailSendEventArgs args)
        {
            args.Logger.WriteToLog(sender, args.Date, args.EventType, args.Email);
        }
    }
}

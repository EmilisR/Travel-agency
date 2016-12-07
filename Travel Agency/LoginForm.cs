using System;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Travel_Agency
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public static string ComputeHash(string input)
        {
            HashAlgorithm sha = SHA256.Create();
            byte[] hashData = sha.ComputeHash(Encoding.ASCII.GetBytes(input));
            return Convert.ToBase64String(hashData);
        }

        private SecureString ConvertToSecureString(string password)
        {
            if (password == null)
                MessageBox.Show("Empty password field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var securePassword = new SecureString();

            foreach (char c in password)
                securePassword.AppendChar(c);

            securePassword.MakeReadOnly();
            return securePassword;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ComputeHash(passwordBox.Text) == FileInput.ReadSetting("Admin pass hash", "App.config") && emailBox.Text == FileInput.ReadSetting("Admin email", "App.config"))
            {
                EmailSender.Password = ConvertToSecureString(passwordBox.Text);
                Dispose();
            }
            else MessageBox.Show("Wrong e-mail and/or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}

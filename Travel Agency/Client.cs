using System;
using System.Linq;

namespace Travel_Agency
{
    [Serializable]
    class Client
    {
        public DateTime RegisterDate { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        private static int _howManyClients = 0;
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public int ClientNumber { get; private set; }

        public static event MainForm.EmailSendEventHandler<Client> EmailSend;

        public Client(string name, string lastName, string email, string mobileNumber, ILogger loggerBox = null, ILogger loggerFile = null, ILogger loggerMail = null)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            MobileNumber = mobileNumber;
            RegisterDate = DateTime.Now;
            _howManyClients++;
            ClientNumber = Program.allClients.OrderByDescending(x => x.Key).FirstOrDefault().Key + 1;
            if (loggerBox != null)
                loggerBox.WriteToLog(this, RegisterDate, "Created client", Email);
            if (loggerFile != null)
                loggerFile.WriteToLog(this, RegisterDate, "Created client", Email);
            if (loggerMail != null)
            {
                if (EmailSend != null)
                    EmailSend(this, new EmailSendEventArgs(Email, "Created client", RegisterDate, loggerMail));
            }
        }

        public override string ToString()
        {
            return "Client number: " + ClientNumber + Environment.NewLine + "Name: " + Name + Environment.NewLine + "Last name: " + LastName + Environment.NewLine + "E-mail: " + Email + Environment.NewLine + "Mobile number: " + MobileNumber + Environment.NewLine + "Registered on: " + RegisterDate.ToShortDateString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    public partial class Client
    {
        public Client(string name, string lastName, string email, string mobileNumber, ILogger loggerBox = null, ILogger loggerFile = null, ILogger loggerMail = null)
        {
            using (var db = new TravelAgencyContext())
            {
                Name = name;
                LastName = lastName;
                Email = email;
                MobileNumber = mobileNumber;
                RegisterDate = DateTime.Now;
                ClientNumber = db.Clients.OrderByDescending(x => x.ClientNumber).FirstOrDefault().ClientNumber + 1;
                if (loggerBox != null)
                    loggerBox.WriteToLog(this, RegisterDate, "Created client", Email);
                if (loggerFile != null)
                    loggerFile.WriteToLog(this, RegisterDate, "Created client", Email);
                if (loggerMail != null)
                {
                    EmailSend?.Invoke(this, new EmailSendEventArgs(Email, "Created client", RegisterDate, loggerMail));
                }
            } 
        }
        public static event MainForm.EmailSendEventHandler<Client> EmailSend;
        public override string ToString()
        {
            return "Client number: " + ClientNumber + Environment.NewLine + "Name: " + Name + Environment.NewLine + "Last name: " + LastName + Environment.NewLine + "E-mail: " + Email + Environment.NewLine + "Mobile number: " + MobileNumber + Environment.NewLine + "Registered on: " + RegisterDate.ToShortDateString();
        }
    }
}

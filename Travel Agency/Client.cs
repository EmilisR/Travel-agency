using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel_Agency
{
    public partial class Client
    {
        public Client() { }
        public Client(string name, string lastName, string email, string mobileNumber, List<ILogger> logs)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            MobileNumber = mobileNumber;
            RegisterDate = DateTime.Now;
            List<Client> list = DatabaseMethods.SelectClients();
            if (list.Count > 0)
            {
                ClientNumber = (from c in list
                                select c.ClientNumber).Max() + 1;
            }
            else ClientNumber = 1;
            foreach (ILogger log in logs)
            {
                if (log != null) log.WriteToLog(this, RegisterDate, "Created client", Email);
            }
        }
        public override string ToString()
        {
            return "Client number: " + ClientNumber + Environment.NewLine + "Name: " + Name + Environment.NewLine + "Last name: " + LastName + Environment.NewLine + "E-mail: " + Email + Environment.NewLine + "Mobile number: " + MobileNumber + Environment.NewLine + "Registered on: " + RegisterDate.ToShortDateString();
        }
    }
}

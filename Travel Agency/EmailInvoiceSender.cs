using System;
using System.Threading.Tasks;

namespace Travel_Agency
{
    class EmailInvoiceSender : ILogger
    {
        public void WriteToLog<T>(T obj, DateTime date, string eventType, string email = "")
        {
            Task.Run(() => EmailSender.SendIt(obj, email, date, eventType));
        }
    }
}

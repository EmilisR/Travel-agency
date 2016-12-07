using System;

namespace Travel_Agency
{
    class EmailInvoiceSender : ILogger
    {
        public void WriteToLog<T>(T obj, DateTime date, string eventType, string email = "")
        {
            EmailSender.SendIt(obj, email, date, eventType);
        }
    }
}

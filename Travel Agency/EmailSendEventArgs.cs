using System;

namespace Travel_Agency
{
    public class EmailSendEventArgs : EventArgs
    {
        public string Email { get; set; }
        public string EventType { get; set; }
        public DateTime Date { get; set; }
        public ILogger Logger { get; set; }
        public EmailSendEventArgs(string email, string eventType, DateTime date, ILogger logger)
        {
            Email = email;
            EventType = eventType;
            Date = date;
            Logger = logger;
        }
    }
}
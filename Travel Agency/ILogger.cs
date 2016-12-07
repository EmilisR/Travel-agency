using System;

namespace Travel_Agency
{
    public interface ILogger
    {
        void WriteToLog<T>(T obj, DateTime date, string eventType, string email = "");
    }
}

using System;
using System.IO;

namespace Travel_Agency
{
    class LogFileWritter : ILogger
    {
        private string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public void WriteToLog<T>(T obj, DateTime date, string eventType, string email = "")
        {
            using (StreamWriter file = new StreamWriter(desktopPath + @"\" + FileInput.ReadSetting("Log file name", "App.config"), true))
            {
                file.WriteLine("Date: " + date.ToLongDateString() + ", " + date.ToShortTimeString() + Environment.NewLine + "Event: " + eventType + Environment.NewLine + "***************************************************************************" + Environment.NewLine + obj.ToString() + Environment.NewLine + "***************************************************************************");
            }
        }
    }
}

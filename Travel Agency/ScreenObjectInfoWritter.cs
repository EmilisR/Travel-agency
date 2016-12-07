using System;
using System.Windows.Forms;

namespace Travel_Agency
{
    class ScreenObjectInfoWritter : ILogger
    {
        public void WriteToLog<T>(T obj, DateTime date, string eventType, string email = "")
        {
            MessageBox.Show(date.ToLongDateString() + ", " + date.ToShortTimeString() + "\nEvent: " + eventType + "\n" + obj.ToString(), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

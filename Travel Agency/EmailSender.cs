using System;
using System.Net;
using System.Net.Mail;
using System.Security;

namespace Travel_Agency
{
    class EmailSender
    {
        public static SecureString Password { private get; set; }
        public static int SendIt<T>(T obj, string email, DateTime date, string eventMessage)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(FileInput.ReadSetting("Admin email", "App.config"));
            msg.To.Add(email);
            msg.Subject = eventMessage + " on " + date.ToLongDateString();
            msg.Body = obj.ToString() + "\nMessage sent: " + DateTime.Now.ToString();
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential(FileInput.ReadSetting("Admin email", "App.config"), Password);
            client.Timeout = 20000;
            try
            {
                client.Send(msg);
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                msg.Dispose();
            }
        }
    }
}

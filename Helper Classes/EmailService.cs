using Software_Engineering_Project_New.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Software_Engineering_Project_New.Helper_Classes
{
    internal class EmailService
    {
        private static EmailService _instance;

        private string username;
        private string password;


        private EmailService()
        {
            username = Settings.Default.EmailUsername;
            password = Settings.Default.EmailPassword;

        }

        public static EmailService getInstanceOfEmailService()
        {
            return _instance ?? (_instance = new EmailService());
        }

        public void sendEmail(string recipient, string subject, string body)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient("smtp.gmail.com");

            mail.From = new System.Net.Mail.MailAddress(username);
            mail.To.Add(recipient);
            mail.Subject = subject;
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

    }
}

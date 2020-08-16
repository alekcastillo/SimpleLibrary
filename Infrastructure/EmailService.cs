using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class EmailService
    {
        protected static EmailService instance { get; private set; }

        private static readonly string EMAIL = "simplelibraryproject@gmail.com";
        private static readonly string PASSWORD = "SimpleLibrary2020";

        protected EmailService()
        { }

        public static EmailService GetInstance()
        {
            if (instance == null)
                instance = new EmailService();

            return instance;
        }

        public void SendEmail(string to, string subject, string body)
        {
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(EMAIL, PASSWORD);
                MailMessage mail = new MailMessage(
                    EMAIL,
                    to,
                    subject,
                    body);
                mail.Priority = MailPriority.High;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error al enviar el email: {ex.Message}");
            }
        }
    }
}

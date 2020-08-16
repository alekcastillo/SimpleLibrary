using Library.Infrastructure;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Execute();
            LibraryContext.GetInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Library.Views.LoginForm());
        }

        public static void Execute()
        {
            var apiKey = Environment.GetEnvironmentVariable("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");
            var client = new SendGridClient("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");
            var from = new EmailAddress("royvargas55@gmail.com", "Roy");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("leonelvegavargas27@gmail.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response =  client.SendEmailAsync(msg);
        }
    }
}

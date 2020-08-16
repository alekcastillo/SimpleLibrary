using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using S22.Imap;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Library.Views
{
    public partial class InfractionForm : Form
    {
        public InfractionForm()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("YourMail","YourPassword");
                MailMessage mail = new MailMessage("royvargas55@gmail.com", txtReceive1.Text, txtSubject.Text, txtBody.Text);
                mail.Priority = MailPriority.High;
                smtp.Send(mail);
                MessageBox.Show("Mail send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

 

        private void txtRecipient_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

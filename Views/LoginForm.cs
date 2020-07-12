using Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;

namespace Library.Views
{
    public partial class LoginForm : Form
    {
        //private LibraryContext _context;

        public LoginForm()
        {
            InitializeComponent();
            bunifuThinButton21.BackColor = Color.Transparent;
            bunifuThinButton22.BackColor = Color.Transparent;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //_context = new LibraryContext();
            //var user = User.Add("Test@gmail.com", "123", "Test", "Meh1");
            //_context.Users.Add(user);
            //_context.SaveChanges();
            //Console.WriteLine("Meh");
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Library.Views.MenuForm mn = new MenuForm();
            mn.Show();
        }
    }
}

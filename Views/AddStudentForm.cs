using Library.Infrastructure;
using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class AddStudentForm : Form
    {
        private LibraryContext context { get; set; }
        private IReloadableForm OriginForm { get; set; }
        private bool IsEdit { get; set; }
        private User User { get; set; }
        public AddStudentForm(IReloadableForm originForm)
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            OriginForm = originForm;
        }

        public AddStudentForm(User user, IReloadableForm originForm)
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            OriginForm = originForm;
            IsEdit = true;
            User = user;
            txtName.Text = User.FirstName;
            txtLastName.Text = User.LastName;
            txtEmail.Text = User.Email;
            SetTitle();
        }

        private void SetTitle()
        {
            var verb = IsEdit ? "Editar" : "Agregar";
            btnAction.Text = verb;
        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                User.Email = txtEmail.Text;
                User.FirstName = txtName.Text;
                User.LastName = txtLastName.Text;
                context.SaveChanges();
            }
            else
            {
                User.Add(
                txtEmail.Text,
                txtName.Text,
                txtLastName.Text); 
            }

            OriginForm.ReloadDataGrid();
            Hide();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}

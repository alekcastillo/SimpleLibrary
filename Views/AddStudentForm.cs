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
        private Student Student { get; set; }
        public AddStudentForm(IReloadableForm originForm)
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            OriginForm = originForm;
        }

        public AddStudentForm(Student student, IReloadableForm originForm)
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            OriginForm = originForm;
            IsEdit = true;
            Student = student;
            txtName.Text = Student.FirstName;
            txtLastName.Text = Student.LastName;
            txtEmail.Text = Student.Email;
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
                Student.Email = txtEmail.Text;
                Student.FirstName = txtName.Text;
                Student.LastName = txtLastName.Text;
                context.SaveChanges();
            }
            else
            {
                Student.Add(
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

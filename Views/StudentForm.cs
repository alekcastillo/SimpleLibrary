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
    public partial class StudentForm : Form, IReloadableForm
    {
        private LibraryContext context { get; set; }
        public StudentForm()
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            DataGridStudent.ColumnCount = 4;
            DataGridStudent.Columns[0].Name = "ID";
            DataGridStudent.Columns[1].Name = "Nombre";
            DataGridStudent.Columns[2].Name = "Apellido";
            DataGridStudent.Columns[3].Name = "Email";
            ReloadDataGrid();
        }

        public void ReloadDataGrid()
        {
            DataGridStudent.Rows.Clear();
            DataGridStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var user in context.Users)
            {
                string[] row = { user.Id.ToString(), user.FirstName, user.LastName, user.Email};
                DataGridStudent.Rows.Add(row);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm bc = new AddStudentForm(this);
            bc.Show();
        }

        private int GetSelectedItemId()
        {
            return int.Parse(DataGridStudent.SelectedRows[0].Cells[0].Value.ToString());
        }

        private User GetSelectedBookType()
        {
            var itemId = GetSelectedItemId();
            return context.Users.Single(User => User.Id == itemId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var user = GetSelectedBookType();
            context.Users.Remove(user);
            context.SaveChanges();
            DataGridStudent.Rows.RemoveAt(DataGridStudent.SelectedRows[0].Index);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var user = GetSelectedBookType();
            AddStudentForm bc = new AddStudentForm(user, this);
            bc.Show();
        }
    }
}

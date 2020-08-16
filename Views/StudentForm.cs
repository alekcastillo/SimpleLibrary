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
            foreach (var student in context.Students)
            {
                string[] row = { student.Id.ToString(), student.FirstName, student.LastName, student.Email};
                DataGridStudent.Rows.Add(row);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm bc = new AddStudentForm(this);
            bc.Show();
        }

        private int GetSelectedStudentId()
        {
            return int.Parse(DataGridStudent.SelectedRows[0].Cells[0].Value.ToString());
        }

        private Student GetSelectedStudent()
        {
            var studentId = GetSelectedStudentId();
            return context.Students.Single(student => student.Id == studentId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var student = GetSelectedStudent();
            context.Students.Remove(student);
            context.SaveChanges();
            DataGridStudent.Rows.RemoveAt(DataGridStudent.SelectedRows[0].Index);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var student = GetSelectedStudent();
            AddStudentForm bc = new AddStudentForm(student, this);
            bc.Show();
        }
    }
}

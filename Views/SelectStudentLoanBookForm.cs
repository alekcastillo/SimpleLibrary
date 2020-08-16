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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class SelectStudentLoanBookForm : Form
    {
        private LibraryContext context { get; set; }
        private IReloadableForm OriginForm { get; set; }
        private Book book { get; set; }

        public SelectStudentLoanBookForm(Book book, IReloadableForm originForm)
        {
            this.book = book;
            context = LibraryContext.GetInstance();
            InitializeComponent();
            OriginForm = originForm;
            FillDropdown();
        }

        private void FillDropdown()
        {
            foreach (var student in context.Students)
                DropStudent.AddItem($"{student.Id}-{student.FirstName} {student.LastName}");
        }

        private Student GetSelectedStudent()
        {
            string selectedStudent = DropStudent.selectedValue;
            var studentId = Int32.Parse(Regex.Split(selectedStudent, "-")[0]);
            return context.Students.Single(student => student.Id == studentId);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            var student = GetSelectedStudent();
            if (student.HasActiveInfraction())
                MessageBox.Show("Este estudiante tiene una infraccion sin pagar, por lo cual no se le pueden prestar mas libros!");
            else
            {
                book.Lend(student);
                OriginForm.ReloadDataGrid();
                Hide();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SelectStudentLoanBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}

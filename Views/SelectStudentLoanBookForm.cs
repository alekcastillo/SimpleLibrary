using Library.Infrastructure;
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
        public SelectStudentLoanBookForm()
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            FillDropdown();
        }

        private void FillDropdown()
        {
            foreach (var student in context.Users)
                DropStudent.AddItem($"{student.Id}-{student.FirstName} {student.LastName}");
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            string selectedStudent = DropStudent.selectedValue;
            int StudentId = Int32.Parse(Regex.Split(selectedStudent, "-")[0]);
            MessageBox.Show($"ID del estudiantes {StudentId}");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

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
    public partial class SetStatusBookForm : Form
    {
        private LibraryContext context { get; set; }
        private IReloadableForm OriginForm { get; set; }
        private Book book { get; set; }

        public SetStatusBookForm(Book book, IReloadableForm originForm)
        {
            this.book = book;
            context = LibraryContext.GetInstance();
            InitializeComponent();
            OriginForm = originForm;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            book.Status = BookStatus.Disponible;
            var student = context.Students.Single(borrowerStudent =>
                borrowerStudent.BorrowedBooks.Contains(book));
            student.BorrowedBooks.Remove(book);
            context.SaveChanges();
            MessageBox.Show("El libro se ha marcado como devuelto correctamente!");
            OriginForm.ReloadDataGrid();
            Hide();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            book.Status = BookStatus.Perdido;
            var studentList = context.Students.Include("BorrowedBooks").ToList();
            var student = studentList.Single(borrowerStudent =>
                borrowerStudent.BorrowedBooks.Contains(book));
            student.BorrowedBooks.Remove(book);
            Infraction.Add(student.Id, book.Id);
            context.SaveChanges();
            MessageBox.Show("El libro se ha marcado como perdido, y se ha añadido una infraccion de 5000 colones al estudiante!");
            OriginForm.ReloadDataGrid();
            Hide();
        }
    }
}

using Library.Infrastructure;
using Library.Models;
using System;
using Library.Interfaces;
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
    public partial class BookStockForm : Form, IReloadableForm
    {
        int indexRow;
        private LibraryContext context { get; set; }
        private BookType bookType { get; set; }

        public BookStockForm(BookType type)
        {
            bookType = type;
            context = LibraryContext.GetInstance();
            InitializeComponent();
            DataGridBook.ColumnCount = 2;
            DataGridBook.Columns[0].Name = "Identificación";
            DataGridBook.Columns[1].Name = "Estado";
            //DataGridBook.Columns[2].Name = "Prestado a";
            ReloadDataGrid();
        }

        public void ReloadDataGrid()
        {
            DataGridBook.Rows.Clear();
            DataGridBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var book in context.Books.Where(book => book.Type.Id == bookType.Id))
            {
                string[] row = { book.Id.ToString(), book.Status.ToString() };
                DataGridBook.Rows.Add(row);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Book.Add(bookType.Id);
            ReloadDataGrid();
        }

        private int GetSelectedBookId()
        {
            return int.Parse(DataGridBook.SelectedRows[0].Cells[0].Value.ToString());
        }

        private Book GetSelectedBook()
        {
            var itemId = GetSelectedBookId();
            return context.Books.Single(bookStock => bookStock.Id == itemId);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var book = GetSelectedBook();
            if (book.Status == BookStatus.Disponible)
            {
                var sb = new SelectStudentLoanBookForm(book, this);
                sb.Show();
            } else
            {
                var sb = new SetStatusBookForm(book, this);
                sb.Show();
            }
        } 

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DataGridBook_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridBook.SelectedRows.Count > 0)
            {
                var book = GetSelectedBook();
                if (book.Status == BookStatus.Disponible)
                    btnAction.Text = "Prestar copia";
                else
                    btnAction.Text = "Marcar copia como...";
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

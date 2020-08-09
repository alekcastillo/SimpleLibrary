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
    public partial class AuthorForm : Form, IReloadableForm
    {
        int indexRow;
        private LibraryContext context { get; set; }
        public AuthorForm()
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            DataGridAuthors.ColumnCount = 2;
            DataGridAuthors.Columns[0].Name = "Identificación";
            DataGridAuthors.Columns[1].Name = "Nombre del autor";
            ReloadDataGrid();
        }

        public void ReloadDataGrid()
        {
            DataGridAuthors.Rows.Clear();
            DataGridAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var author in context.BookAuthors)
            {
                string[] row = { author.Id.ToString(), author.Title };
                DataGridAuthors.Rows.Add(row);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBookCatalogForm bc = new AddBookCatalogForm(BookCatalogType.BookAuthor, this);
            bc.Show();
        }

        private int GetSelectedItemId()
        {
            return int.Parse(DataGridAuthors.SelectedRows[0].Cells[0].Value.ToString());
        }

        private BookAuthor GetSelectedAuthor()
        {
            var itemId = GetSelectedItemId();
            return context.BookAuthors.Single(BookAuthor => BookAuthor.Id == itemId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var author = GetSelectedAuthor();
            context.BookAuthors.Remove(author);
            context.SaveChanges();
            DataGridAuthors.Rows.RemoveAt(DataGridAuthors.SelectedRows[0].Index);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var author = GetSelectedAuthor();
            AddBookCatalogForm bc = new AddBookCatalogForm(author, this);
            bc.Show();

        }

        private void lbAutores_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

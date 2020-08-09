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
    public partial class BookTypeForm : Form, IReloadableForm
    {
        int indexRow;
        private LibraryContext context { get; set; }
        public BookTypeForm()
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            DataGridBookType.ColumnCount = 7;
            DataGridBookType.Columns[0].Name = "ID";
            DataGridBookType.Columns[1].Name = "Nombre";
            DataGridBookType.Columns[2].Name = "Tema";
            DataGridBookType.Columns[3].Name = "Autor";
            DataGridBookType.Columns[4].Name = "Editorial";
            DataGridBookType.Columns[5].Name = "Año";
            DataGridBookType.Columns[6].Name = "Páginas";
            ReloadDataGrid();
        }

        public void ReloadDataGrid()
        {
            DataGridBookType.Rows.Clear();
            DataGridBookType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var booktype in context.BookTypes)
            {
                string[] row = { booktype.Id.ToString(), booktype.Title, booktype.Subject.Title,
                    booktype.Author.Title, booktype.Publisher.Title, booktype.Year.ToString(), booktype.Pages.ToString()
                };
                DataGridBookType.Rows.Add(row);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBookTypeForm bc = new AddBookTypeForm(this);
            bc.Show();
        }

        private int GetSelectedItemId()
        {
            return int.Parse(DataGridBookType.SelectedRows[0].Cells[0].Value.ToString());
        }

        private BookType GetSelectedBookType()
        {
            var itemId = GetSelectedItemId();
            return context.BookTypes.Single(BookType => BookType.Id == itemId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var BookType = GetSelectedBookType();
            context.BookTypes.Remove(BookType);
            context.SaveChanges();
            DataGridBookType.Rows.RemoveAt(DataGridBookType.SelectedRows[0].Index);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var bookType = GetSelectedBookType();
            AddBookTypeForm bc = new AddBookTypeForm(bookType, this);
            bc.Show();
        }
    }
}

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
    public partial class PublisherForm : Form, IReloadableForm
    {
        int indexRow;
        private LibraryContext context { get; set; }
        public PublisherForm()
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            DataGridPublisher.ColumnCount = 2;
            DataGridPublisher.Columns[0].Name = "Identificación";
            DataGridPublisher.Columns[1].Name = "Nombre de la editorial";
            ReloadDataGrid();
        }

        public void ReloadDataGrid()
        {
            DataGridPublisher.Rows.Clear();
            DataGridPublisher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var publisher in context.BookPublishers)
            {
                string[] row = { publisher.Id.ToString(), publisher.Title };
                DataGridPublisher.Rows.Add(row);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBookCatalogForm bc = new AddBookCatalogForm(BookCatalogType.BookPublisher, this);
            bc.Show();
        }

        private int GetSelectedItemId()
        {
            return int.Parse(DataGridPublisher.SelectedRows[0].Cells[0].Value.ToString());
        }

        private BookPublisher GetSelectedPublisher()
        {
            var itemId = GetSelectedItemId();
            return context.BookPublishers.Single(BookPublisher => BookPublisher.Id == itemId);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var publisher = GetSelectedPublisher();
            AddBookCatalogForm bc = new AddBookCatalogForm(publisher, this);
            bc.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var publisher = GetSelectedPublisher();
            context.BookPublishers.Remove(publisher);
            context.SaveChanges();
            MessageBox.Show("La editorial se ha eliminado correctamente!");
            DataGridPublisher.Rows.RemoveAt(DataGridPublisher.SelectedRows[0].Index);
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void DataGridPublisher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbAutores_Click(object sender, EventArgs e)
        {

        }
    }
}

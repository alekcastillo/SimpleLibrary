using Library.Infrastructure;
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
    public partial class PublisherForm : Form
    {
        int indexRow;
        private LibraryContext _context { get; set; }

        public PublisherForm()
        {
            _context = LibraryContext.GetInstance();
            InitializeComponent();
            DataGridPublisher.ColumnCount = 2;
            DataGridPublisher.Columns[0].Name = "Identificación";
            DataGridPublisher.Columns[1].Name = "Nombre de la editorial";
            DataGridPublisher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var publisher in _context.BookPublishers)
            {
                string[] row = { publisher.Id.ToString(), publisher.Title };
                DataGridPublisher.Rows.Add(row);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddBookCatalogForm bc = new AddBookCatalogForm(3);
            bc.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var item = DataGridPublisher.SelectedRows[0].Index;
            var publisher = _context.BookPublishers.FirstOrDefault(bookPublisher => bookPublisher.Id == item);
            _context.BookPublishers.Remove(publisher);
            DataGridPublisher.Rows.RemoveAt(DataGridPublisher.SelectedRows[0].Index);
        }

        private void DataGridPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = DataGridPublisher.Rows[indexRow];
            txtName.Text = row.Cells[1].Value.ToString();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var item = DataGridPublisher.SelectedRows[0].Index;
            var publisher = _context.BookPublishers.FirstOrDefault(bookPublisher => bookPublisher.Id == item);
            if (publisher != null) publisher.Title = txtName.Text;
            DataGridViewRow newDataRow = DataGridPublisher.Rows[indexRow];
            newDataRow.Cells[1].Value = txtName.Text;
        }
    }
}

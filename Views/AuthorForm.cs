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
    public partial class AuthorForm : Form
    {
        //private DataView dv;
        int indexRow;
        public AuthorForm()
        {
            InitializeComponent();

            var dataService = DataService.GetInstance();
            DataGridAuthors.ColumnCount = 2;
            DataGridAuthors.Columns[0].Name = "Identificación";
            DataGridAuthors.Columns[1].Name = "Nombre del autor";
            DataGridAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //BindingSource bs = new BindingSource();
            //bs.DataSource = DataGridAuthors.DataSource;
            //DataTable dat = (DataTable)(bs.DataSource);
         

            foreach (var author in dataService.BookAuthors)
            {
                string[] row = { author.Id.ToString(), author.Title };
                DataGridAuthors.Rows.Add(row);
            }
            
            //dv = new DataView(dat);

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddBookCatalogForm bc = new AddBookCatalogForm(2);
            bc.Show();
        }

     
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            //dv.RowFilter = string.Format("Title Like '%{0}%'", txtFilter.Text);
            //DataGridAuthors.DataSource = dv;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var dataService = DataService.GetInstance();
            var item = DataGridAuthors.SelectedRows[0].Index;
            var author = dataService.BookAuthors.FirstOrDefault(bookAuthor => bookAuthor.Id == item);
            dataService.BookAuthors.Remove(author);
            DataGridAuthors.Rows.RemoveAt(DataGridAuthors.SelectedRows[0].Index);
        }

        private void DataGridAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = DataGridAuthors.Rows[indexRow];
            txtName.Text = row.Cells[1].Value.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var dataService = DataService.GetInstance();
            var item = DataGridAuthors.SelectedRows[0].Index;
            var author = dataService.BookAuthors.FirstOrDefault(bookAuthor => bookAuthor.Id == item);
            if (author != null) author.Title = txtName.Text;
            DataGridViewRow newDataRow = DataGridAuthors.Rows[indexRow];
            newDataRow.Cells[1].Value = txtName.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

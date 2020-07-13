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
    public partial class SubjectForm : Form
    {
        int indexRow;
        public SubjectForm()
        {
            InitializeComponent();
            var dataService = DataService.GetInstance();
            DataGridSubject.ColumnCount = 2;
            DataGridSubject.Columns[0].Name = "Identificación";
            DataGridSubject.Columns[1].Name = "Nombre del tema";
            DataGridSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var subject in dataService.BookSubjects)
            {
                string[] row = { subject.Id.ToString(), subject.Title };
                DataGridSubject.Rows.Add(row);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddBookCatalogForm bc = new AddBookCatalogForm(1);
            bc.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var dataService = DataService.GetInstance();
            var item = DataGridSubject.SelectedRows[0].Index;
            var subject = dataService.BookSubjects.FirstOrDefault(bookSubject => bookSubject.Id == item);
            dataService.BookSubjects.Remove(subject);
            DataGridSubject.Rows.RemoveAt(DataGridSubject.SelectedRows[0].Index);
        }

        private void DataGridSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = DataGridSubject.Rows[indexRow];
            txtName.Text = row.Cells[1].Value.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var dataService = DataService.GetInstance();
            var item = DataGridSubject.SelectedRows[0].Index;
            var subject = dataService.BookSubjects.FirstOrDefault(bookSubject => bookSubject.Id == item);
            if (subject != null) subject.Title = txtName.Text;
            DataGridViewRow newDataRow = DataGridSubject.Rows[indexRow];
            newDataRow.Cells[1].Value = txtName.Text;
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
    }
}

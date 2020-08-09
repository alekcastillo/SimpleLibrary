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
    public partial class SubjectForm : Form, IReloadableForm
    {
        int indexRow;
        private LibraryContext context { get; set; }

        public SubjectForm()
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            DataGridSubject.ColumnCount = 2;
            DataGridSubject.Columns[0].Name = "Identificación";
            DataGridSubject.Columns[1].Name = "Nombre del tema";
            ReloadDataGrid();
        }

        public void ReloadDataGrid()
        {
            DataGridSubject.Rows.Clear();
            DataGridSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var subject in context.BookSubjects)
            {
                string[] row = { subject.Id.ToString(), subject.Title };
                DataGridSubject.Rows.Add(row);
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddBookCatalogForm bc = new AddBookCatalogForm(BookCatalogType.BookSubject, this);
            bc.Show();
        }

        private int GetSelectedItemId()
        {
            return int.Parse(DataGridSubject.SelectedRows[0].Cells[0].Value.ToString());
        }

        private BookSubject GetSelectedSubject()
        {
            var itemId = GetSelectedItemId();
            return context.BookSubjects.Single(bookSubject => bookSubject.Id == itemId);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var subject = GetSelectedSubject();
            context.BookSubjects.Remove(subject);
            context.SaveChanges();
            DataGridSubject.Rows.RemoveAt(DataGridSubject.SelectedRows[0].Index);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            var subject = GetSelectedSubject();
            AddBookCatalogForm bc = new AddBookCatalogForm(subject, this);
            bc.Show();
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
    }
}

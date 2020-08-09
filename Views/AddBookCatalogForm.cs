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
    public partial class AddBookCatalogForm : Form
    {
        private LibraryContext context { get; set; }
        private BookCatalogType CatalogType { get; set; }
        private IReloadableForm OriginForm { get; set; }

        private bool IsEdit { get; set; }

        private BookAuthor Author { get; set; }

        private BookPublisher Publisher { get; set; }

        private BookSubject Subject { get; set; }



        public AddBookCatalogForm(BookCatalogType catalogType, IReloadableForm originForm)
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            CatalogType = catalogType;
            OriginForm = originForm;
            SetTitle();
        }

        public AddBookCatalogForm(BookSubject subject, IReloadableForm originForm)
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            CatalogType = BookCatalogType.BookSubject;
            OriginForm = originForm;
            IsEdit = true;
            Subject = subject;
            txtName.Text = Subject.Title;
            SetTitle();
        }

        private void SetTitle()
        {
            var article = "un";
            var catalogName = "";
            var verb = IsEdit ? "Editar" : "Agregar";

            switch (CatalogType)
            {
                case BookCatalogType.BookAuthor:
                    catalogName = "autor";
                    break;
                case BookCatalogType.BookPublisher:
                    catalogName = "editorial";
                    article = "una";
                    break;
                case BookCatalogType.BookSubject:
                    catalogName = "tema";
                    break;
            }

            LabelData.Text = $"{verb} {article} {catalogName}";
            btnAction.Text = verb;
        }

        private void CheckAuthor_OnChange(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                switch (CatalogType)
                {
                    case BookCatalogType.BookSubject:
                        Subject.Title = txtName.Text;
                        context.SaveChanges();
                        break;
                    case BookCatalogType.BookAuthor:
                        Author.Title = txtName.Text;
                        context.SaveChanges();
                        break;
                    case BookCatalogType.BookPublisher:
                        Publisher.Title = txtName.Text;
                        context.SaveChanges();
                        break;
                }
            } else
            {
                switch (CatalogType)
                {
                    case BookCatalogType.BookSubject:
                        BookSubject.Add(txtName.Text);
                        break;
                    case BookCatalogType.BookAuthor:
                        BookAuthor.Add(txtName.Text);
                        break;
                    case BookCatalogType.BookPublisher:
                        BookPublisher.Add(txtName.Text);
                        break;
                }
            }

            OriginForm.ReloadDataGrid();
            Hide();
        }

        private void AddBookCatalogForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

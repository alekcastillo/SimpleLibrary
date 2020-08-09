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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Views
{
    public partial class AddBookTypeForm : Form
    {

        private LibraryContext context { get; set; }
        private IReloadableForm OriginForm { get; set; }

        private bool IsEdit { get; set; }

        private BookType Type { get; set; }


        public AddBookTypeForm(IReloadableForm originForm)
        {

            context = LibraryContext.GetInstance();
            InitializeComponent();
            OriginForm = originForm;
            FillDropdown();
        }

        public AddBookTypeForm(BookType type, IReloadableForm originForm)
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            OriginForm = originForm;
            IsEdit = true;
            Type = type;
            txtName.Text = Type.Title;
            txtYear.Text = Type.Year.ToString();
            txtPages.Text = Type.Pages.ToString();
            FillDropdown();
            SetTitle();
        }

        private void SetTitle()
        {
            var verb = IsEdit ? "Editar" : "Agregar";
            btnAction.Text = verb;
        }

        private void FillDropdown()
        {
            foreach (var publisher in context.BookPublishers)
                DropPublisher.AddItem($"{publisher.Id}-{publisher.Title}");

            foreach (var author in context.BookAuthors)
                DropAuthor.AddItem($"{author.Id}-{author.Title}");

            foreach (var subject in context.BookSubjects)
                DropSubject.AddItem($"{subject.Id}-{subject.Title}");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string selectedSubject = DropSubject.selectedValue;
            int subjectId = Int32.Parse(Regex.Split(selectedSubject, "-")[0]);
            string selectedAuthor = DropAuthor.selectedValue;
            int authorId = Int32.Parse(Regex.Split(selectedAuthor, "-")[0]);
            string selectedPublisher = DropPublisher.selectedValue;
            int publisherId = Int32.Parse(Regex.Split(selectedPublisher, "-")[0]);

            if (IsEdit)
            {
                Type.Title = txtName.Text;
                Type.Year = Int32.Parse(txtYear.Text);
                Type.Pages = Int32.Parse(txtPages.Text);

                var subject = context.BookSubjects.Single(
                    bookSubject => bookSubject.Id == subjectId);
                var author = context.BookAuthors.Single(
                    bookAuthor => bookAuthor.Id == authorId);
                var publisher = context.BookPublishers.Single(
                    bookPublisher => bookPublisher.Id == publisherId);

                Type.Subject = subject;
                Type.Author = author;
                Type.Publisher = publisher;
                context.SaveChanges();
            }
            else
            {
                BookType.Add(
                txtName.Text,
                subjectId,
                authorId,
                publisherId,
                Int32.Parse(txtYear.Text),
                Int32.Parse(txtPages.Text)); ;
            }

            OriginForm.ReloadDataGrid();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtPages_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BookType_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtYear_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

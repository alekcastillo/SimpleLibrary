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
    public partial class BookType : Form
    {
        public BookType()
        {
            InitializeComponent();
            var dataService = DataService.GetInstance();

            foreach (var publisher in dataService.BookPublishers)
                DropPublisher.AddItem(publisher.Title);

            foreach (var author in dataService.BookAuthors)
                DropAuthor.AddItem(author.Title);

            foreach (var subject in dataService.BookSubjects)
                DropSubject.AddItem(subject.Title);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

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

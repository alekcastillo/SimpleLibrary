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
        private int CatalogType { get; set; }

        public AddBookCatalogForm(int catalogType)
        {
            InitializeComponent();
            CatalogType = catalogType;
        }

        private void CheckAuthor_OnChange(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            switch (CatalogType)
            {
                case 1: BookSubject.Add(txtName.Text); break;
                case 2: BookAuthor.Add(txtName.Text); break;
                case 3: BookPublisher.Add(txtName.Text); break;
            }
        }
    }
}

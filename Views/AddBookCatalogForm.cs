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
            if (catalogType == 1) LabelData.Text = "Agregue un nuevo tema";
            if (catalogType == 2) LabelData.Text = "Agregue un nuevo autor";
            if (catalogType == 3) LabelData.Text = "Agregue una nueva editorial";
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
                case 1: BookSubject.Add(txtName.Text);
                    txtName.Text = " ";
                    break;
                case 2: 
                    BookAuthor.Add(txtName.Text);
                    txtName.Text = " ";
                    break;
                case 3: BookPublisher.Add(txtName.Text);
                    txtName.Text = " ";
                    break;
            }
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

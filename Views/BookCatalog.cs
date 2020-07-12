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
    public partial class BookCatalog : Form
    {
        public BookCatalog()
        {
            InitializeComponent();
            CheckSubject.Checked = false;
            CheckAuthor.Checked = false;
            CheckPublisher.Checked = false;
            
        }

        private void CheckAuthor_OnChange(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (CheckSubject.Checked == true)
            {
                BookSubject.Add(txtName.Text);

            }
            if (CheckAuthor.Checked == true)
            {
                BookAuthor.Add(txtName.Text);
            }
            if (CheckPublisher.Checked == true)
            {
                BookPublisher.Add(txtName.Text);
            }
        }
    }
}

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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customeDesign();
        }
        private void customeDesign() {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        public void hideSubMenu() {
            if (panel1.Visible == true) panel1.Visible = false;
            if (panel2.Visible == true) panel2.Visible = false;
            if (panel3.Visible == true) panel3.Visible = false;
        }

        public void showeSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton18_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            showeSubMenu(panel1);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //codigo
            hideSubMenu();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton15_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            showeSubMenu(panel2);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            showeSubMenu(panel3);
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
    }
}

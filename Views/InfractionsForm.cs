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
    public partial class InfractionsForm : Form, IReloadableForm
    {
        private LibraryContext context { get; set; }
        public InfractionsForm()
        {
            context = LibraryContext.GetInstance();
            InitializeComponent();
            DataGridInfraction.ColumnCount = 3;
            DataGridInfraction.Columns[0].Name = "Numero de infracción";
            DataGridInfraction.Columns[1].Name = "Nombre del estudiante";
            DataGridInfraction.Columns[2].Name = "Libro";
            ReloadDataGrid();
        }

        public void ReloadDataGrid()
        {
            DataGridInfraction.Rows.Clear();
            DataGridInfraction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (var infraction in context.Infractions.Include("Student").Include("Book"))
            {
                string[] row = { infraction.Id.ToString(), $"{infraction.Student.FirstName} {infraction.Student.LastName}", 
                    infraction.Book.Id.ToString() };
                DataGridInfraction.Rows.Add(row);
            }

        }
        private int GetSelectedItemId()
        {
            return int.Parse(DataGridInfraction.SelectedRows[0].Cells[0].Value.ToString());
        }

        private Infraction GetSelectedInfraction()
        {
            var itemId = GetSelectedItemId();
            return context.Infractions.Single(Infraction => Infraction.Id == itemId);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var infraction = GetSelectedInfraction();
            context.Infractions.Remove(infraction);
            context.SaveChanges();
            MessageBox.Show("La infraccion se ha eliminado correctamente!");
            DataGridInfraction.Rows.RemoveAt(DataGridInfraction.SelectedRows[0].Index);
        }
    }
}

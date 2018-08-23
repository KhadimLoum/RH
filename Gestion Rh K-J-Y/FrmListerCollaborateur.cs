using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Rh_K_J_Y
{
    public partial class FrmListerCollaborateur : Form
    {
        
        public FrmListerCollaborateur()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void afficherCollaborateur()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add(new DataColumn("Matricule",typeof(string)));
            dt.Columns.Add(new DataColumn("Etat Civile", typeof(string)));
            dt.Columns.Add(new DataColumn("Nom", typeof(string)));
            dt.Columns.Add(new DataColumn("Nom", typeof(string)));
            dt.Columns.Add(new DataColumn("Prenom", typeof(string)));
            dt.Columns.Add(new DataColumn("Code postale", typeof(string)));
            dt.Columns.Add(new DataColumn("Ville", typeof(string)));
            dt.Columns.Add(new DataColumn("Adresse 1", typeof(string)));
            dt.Columns.Add(new DataColumn("Adresse 2", typeof(string)));
            dt.Columns.Add(new DataColumn("Salaire", typeof(string)));
            dt.Columns.Add(new DataColumn("Qualification", typeof(string)));
            dt.Columns.Add(new DataColumn("Situation Familiale", typeof(string)));
            dt.Columns.Add(new DataColumn("Service", typeof(string)));
        }

        private void FrmLister_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

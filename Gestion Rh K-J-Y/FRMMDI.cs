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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            LCollaborateurs.MDI = this;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void rHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ressourcesHumainesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rHToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void listeDesCollaborateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void listeDesCollaborateursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void listeDeToutLesCollaborateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmListerCollaborateur listCollaborateurs = new FrmListerCollaborateur();
            listCollaborateurs.MDIparent = this;
            listCollaborateurs.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajouterDesCollaborateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutCollaborateur listCollaborateurs = new FrmAjoutCollaborateur();
            listCollaborateurs.MDIparent = this;
            listCollaborateurs.Show();
        }
    }
}

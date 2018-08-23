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
            Donnees.MDI = this;
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
            FrmListerCollaborateur listCollaborateurs = new FrmListerCollaborateur();
            listCollaborateurs.MdiParent = this;
            listCollaborateurs.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }
    }
}

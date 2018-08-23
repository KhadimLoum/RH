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
    public partial class FrmAjoutCollaborateur : Form
    {
        public FrmAjoutCollaborateur()
        {
        }

        public FrmAjoutCollaborateur(Collaborateur leCollaborateur)
        {
            InitializeComponent();
        }

        public MDI MDIparent { get; internal set; }

        private void Enregistrer_un_nouveau_ollaborateur_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

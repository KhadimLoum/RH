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
        public MDI MDIparent { get; internal set; }
        private Collaborateur lecollaborateur;
        private LCollaborateurs lCollaborateurs = new LCollaborateurs();


        public FrmListerCollaborateur()
        {
            InitializeComponent();
            this.init();
            this.afficherCollaborateurs();
        }

        public void init()
        {
            Collaborateur c1, c2, c3, c4;
            c1 = new Collaborateur(1, "M", "Loum", "Khadim", "73000", "Orléans", "5 rue d", "6565", 20000, "Boss", "Célibataire", "Administartion", 2654, 6547);
            c2 = new Collaborateur(2, "M", "Loum", "Khadim", "73000", "Orléans", "5 rue ", "8768766", 20000, "Boss", "Célibataire", "Administartion", 2789, 6541);
            c3 = new Collaborateur(3, "M", "Loum", "Khadim", "73000", "Orléans", "5 r", "678687", 20000, "Boss", "Célibataire", "Administartion", 2456, 6325);
            c4 = new Collaborateur(4, "M", "Loum", "Khadim", "73000", "Orléans", "55s", "676576", 20000, "Boss", "Célibataire", "Administartion", 2346, 3156);
            if (LCollaborateurs.listCollaborateur != null)
            {
                LCollaborateurs.listCollaborateur.Clear();
            }

            Donnees.listCollaborateur.Add(c1. MATRICULE, c1);
            Donnees.listCollaborateur.Add(c2.MATRICULE, c2);
            Donnees.listCollaborateur.Add(c3.MATRICULE, c3);
            Donnees.listCollaborateur.Add(c4.MATRICULE, c4);
           


            this.rbService.Checked = true;
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

        public void afficherCollaborateurs()
        {
            // DataTable : pour recopier les stagiaires (stockés dans la collection) ;
            // à relier au DataGridView pour personnaliser son affichage
            DataTable dt = new DataTable();
            DataRow dr;    // ligne de la datatable

            // ajout à la datatable de 10 colonnes personnalisées 
            dt.Columns.Add(new DataColumn("Matricule", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Etat_Civil", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Code Postal", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse 1", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse 2", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Salaire", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Qualification", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Situation Familiale", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Service", typeof(System.String)));


            foreach (Collaborateur Collabo in LCollaborateurs.listCollaborateur.Values)
            {
                // instanciation DataRow (= ligne du DataTable)
                dr = dt.NewRow();
                // affectation des 10 colonnes
                dr[0] = Collabo.MATRICULE;
                dr[1] = Collabo.ETATCIVIL;
                dr[2] = Collabo.NOM;
                dr[3] = Collabo.PRENOM;
                dr[4] = Collabo.CodePostal ;
                dr[5] = Collabo.VILLE;
                dr[6] = Collabo.ADRESSE1;
                dr[7] = Collabo.ADRESSE2;
                dr[8] = Collabo.SALAIRE;
                dr[9] = Collabo.QUALIFICATIONS;
                dr[10] = Collabo.SITUATIONFAMILIALE;
                dr[11] = Collabo.SERVICE;
                // ajout de la ligne à la Datatable
                dt.Rows.Add(dr);

            }

            // donne les donnee a la datagridview
            //Relie DataTABLE a DATAGRID
            this.dgvListCollaborateurs.DataSource = dt.DefaultView;


            // VALIDE BTN SUPPRIMER SI QUELQUECHOSE EST SELECTIONER EN DATAGRIVIEW
            this.btnSupprimer.Enabled = (this.dgvListCollaborateurs.SelectedRows == null ? false : true);
            //this.btnSupprimer.Enabled = true;

            dt = null;
            dr = null;

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

        private void button3_Click(object sender, EventArgs e)
        {
            FrmListerCollaborateur FrmPrinc = new FrmListerCollaborateur();
            FrmPrinc.Show();
            this.Hide();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLancer_Click(object sender, EventArgs e)
        {
            if (this.txtRecherche != null)
            {
                if (this.rbService.Checked == true)
                {
                    ((DataView)(this.dgvListCollaborateurs.DataSource)).RowFilter = "Service like '%" +
               txtRecherche.Text + "%'";
                }
                else if (this.rbtNom.Checked == true)
                {
                    ((DataView)(this.dgvListCollaborateurs.DataSource)).RowFilter = "Nom like '%" +
                   txtRecherche.Text + "%'";
                }
                else if (this.rbEtatCivile.Checked == true)
                {

                    ((DataView)(this.dgvListCollaborateurs.DataSource)).RowFilter = string.Format("Etat_Civil LIKE '{0}'", txtRecherche.Text); ;
                }

            }
        }

        private void rbtAfficherTout_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRecherche.Text = null;
            ((DataView)(this.dgvListCollaborateurs.DataSource)).RowFilter = null;
            this.rbService.Checked = true;
            // on raffraichit la liste des Collaborateurs
            this.afficherCollaborateurs();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           
        }
        private void dgvListCollaborateurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Ouvrir la feuille détail en lecture seule en y affichant
            //le Collaborateur qui correspond à la ligne double-cliquée
            Int32 leMatcollaborateur;

            try
            {

                //récupère le matricule du Collaborateur cliqué dans la datagridview
                leMatcollaborateur = (Int32)(this.dgvListCollaborateurs.CurrentRow.Cells[0].Value);

                //MessageBox.Show("Le Numéro du Collaborateur est :" + leMatcollaborateur);

                Collaborateur leCollaborateur = LCollaborateurs.listCollaborateur[leMatcollaborateur] as Collaborateur;

                //Collaborateur leCollaborateur = Donnees.Lcl.RechercherClient(leMatcollaborateur) as Collaborateur;

                //MessageBox.Show("Le Collaborateur est :" + leCollaborateur);

                // instancie un form détail pour ce Collaborateur (pour préparer la 
                // modification du Collaborateur

                FrmAjoutCollaborateur frmVisu = new FrmAjoutCollaborateur(leCollaborateur);
                frmVisu.ShowDialog();
                this.afficherCollaborateurs();
            }
            catch(Exception esp)
            {
                MessageBox.Show("lalalalalalala");
            }



    }

        private void dgvListCollaborateurs_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}

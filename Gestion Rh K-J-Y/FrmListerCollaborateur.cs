﻿using System;
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

        public FrmListerCollaborateur()
        {
            InitializeComponent();
            this.init();
            this.afficherCollaborateurs();
        }

        public void init()
        {
            Collaborateur c1, c2, c3, c4;
            c1 = new Collaborateur(1, "M", "Loum", "Khadim", "73000", "Orléans", "5 rue des Chapélis", "", 20000, "Boss", "Célibataire", "Administartion", 2654, 6547);
            c2 = new Collaborateur(2, "M", "Loum", "Khadim", "73000", "Orléans", "5 rue des Chapélis", "", 20000, "Boss", "Célibataire", "Administartion", 2789, 6541);
            c3 = new Collaborateur(3, "M", "Loum", "Khadim", "73000", "Orléans", "5 rue des Chapélis", "", 20000, "Boss", "Célibataire", "Administartion", 2456, 6325);
            c4 = new Collaborateur(4, "M", "Loum", "Khadim", "73000", "Orléans", "5 rue des Chapélis", "", 20000, "Boss", "Célibataire", "Administartion", 2346, 3156);

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
            dt.Columns.Add(new DataColumn("Service", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse 1", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse 2", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Code Postal", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Situation de Famille", typeof(System.String)));

            foreach (Collaborateur Collabo in Donnees.listCollaborateur.Values)
            {
                // instanciation DataRow (= ligne du DataTable)
                dr = dt.NewRow();
                // affectation des 10 colonnes
                dr[0] = Collabo.MATRICULE;
                dr[1] = Collabo.ETATCIVIL;
                dr[2] = Collabo.NOM;
                dr[3] = Collabo.PRENOM;
                dr[4] = Collabo.SERVICE;
                dr[5] = Collabo.ADRESSE1;
                dr[6] = Collabo.ADRESSE2;
                dr[7] = Collabo.CodePostal;
                dr[8] = Collabo.VILLE;
                dr[9] = Collabo.SITUATIONFAMILIALE;

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
    }
}

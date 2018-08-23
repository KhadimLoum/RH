namespace Gestion_Rh_K_J_Y
{
    partial class FrmAjoutCollaborateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMat = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblCivil = new System.Windows.Forms.Label();
            this.lblAdress1 = new System.Windows.Forms.Label();
            this.lblAdress2 = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblSitFam = new System.Windows.Forms.Label();
            this.gbxContrat = new System.Windows.Forms.GroupBox();
            this.txtIndemnite = new System.Windows.Forms.TextBox();
            this.txtBrut = new System.Windows.Forms.TextBox();
            this.lblBrut = new System.Windows.Forms.Label();
            this.cbxService = new System.Windows.Forms.ComboBox();
            this.cbxStatut = new System.Windows.Forms.ComboBox();
            this.txtEcole = new System.Windows.Forms.TextBox();
            this.txtInterim = new System.Windows.Forms.TextBox();
            this.cbxFonction = new System.Windows.Forms.ComboBox();
            this.cbxQualif = new System.Windows.Forms.ComboBox();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.cbxTypeContrat = new System.Windows.Forms.ComboBox();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblInterim = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblFinContrat = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblEcole = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblIndemnite = new System.Windows.Forms.Label();
            this.lblFonction = new System.Windows.Forms.Label();
            this.lblQualif = new System.Windows.Forms.Label();
            this.lblTypeContrat = new System.Windows.Forms.Label();
            this.lblDebutContrat = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.cbxCivil = new System.Windows.Forms.ComboBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.cbxSitFam = new System.Windows.Forms.ComboBox();
            this.txtAdress1 = new System.Windows.Forms.TextBox();
            this.txtAdress2 = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gbxContrat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Location = new System.Drawing.Point(12, 8);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(50, 13);
            this.lblMat.TabIndex = 0;
            this.lblMat.Text = "Matricule";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(179, 8);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(314, 8);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblCivil
            // 
            this.lblCivil.AutoSize = true;
            this.lblCivil.Location = new System.Drawing.Point(68, 8);
            this.lblCivil.Name = "lblCivil";
            this.lblCivil.Size = new System.Drawing.Size(47, 13);
            this.lblCivil.TabIndex = 3;
            this.lblCivil.Text = "Etat civil";
            this.lblCivil.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAdress1
            // 
            this.lblAdress1.AutoSize = true;
            this.lblAdress1.Location = new System.Drawing.Point(61, 65);
            this.lblAdress1.Name = "lblAdress1";
            this.lblAdress1.Size = new System.Drawing.Size(54, 13);
            this.lblAdress1.TabIndex = 4;
            this.lblAdress1.Text = "Adresse 1";
            // 
            // lblAdress2
            // 
            this.lblAdress2.AutoSize = true;
            this.lblAdress2.Location = new System.Drawing.Point(242, 65);
            this.lblAdress2.Name = "lblAdress2";
            this.lblAdress2.Size = new System.Drawing.Size(54, 13);
            this.lblAdress2.TabIndex = 5;
            this.lblAdress2.Text = "Adresse 2";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(353, 65);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(64, 13);
            this.lblCP.TabIndex = 6;
            this.lblCP.Text = "Code Postal";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(472, 66);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 7;
            this.lblVille.Text = "Ville";
            // 
            // lblSitFam
            // 
            this.lblSitFam.AutoSize = true;
            this.lblSitFam.Location = new System.Drawing.Point(434, 8);
            this.lblSitFam.Name = "lblSitFam";
            this.lblSitFam.Size = new System.Drawing.Size(88, 13);
            this.lblSitFam.TabIndex = 8;
            this.lblSitFam.Text = "Situation familiale";
            // 
            // gbxContrat
            // 
            this.gbxContrat.Controls.Add(this.txtIndemnite);
            this.gbxContrat.Controls.Add(this.txtBrut);
            this.gbxContrat.Controls.Add(this.lblBrut);
            this.gbxContrat.Controls.Add(this.cbxService);
            this.gbxContrat.Controls.Add(this.cbxStatut);
            this.gbxContrat.Controls.Add(this.txtEcole);
            this.gbxContrat.Controls.Add(this.txtInterim);
            this.gbxContrat.Controls.Add(this.cbxFonction);
            this.gbxContrat.Controls.Add(this.cbxQualif);
            this.gbxContrat.Controls.Add(this.cbxMotif);
            this.gbxContrat.Controls.Add(this.cbxTypeContrat);
            this.gbxContrat.Controls.Add(this.dtpDebut);
            this.gbxContrat.Controls.Add(this.dtpFin);
            this.gbxContrat.Controls.Add(this.lblInterim);
            this.gbxContrat.Controls.Add(this.lblMotif);
            this.gbxContrat.Controls.Add(this.lblFinContrat);
            this.gbxContrat.Controls.Add(this.lblService);
            this.gbxContrat.Controls.Add(this.lblEcole);
            this.gbxContrat.Controls.Add(this.lblStatut);
            this.gbxContrat.Controls.Add(this.lblIndemnite);
            this.gbxContrat.Controls.Add(this.lblFonction);
            this.gbxContrat.Controls.Add(this.lblQualif);
            this.gbxContrat.Controls.Add(this.lblTypeContrat);
            this.gbxContrat.Controls.Add(this.lblDebutContrat);
            this.gbxContrat.Location = new System.Drawing.Point(11, 122);
            this.gbxContrat.Name = "gbxContrat";
            this.gbxContrat.Size = new System.Drawing.Size(536, 249);
            this.gbxContrat.TabIndex = 9;
            this.gbxContrat.TabStop = false;
            this.gbxContrat.Text = "Contrat initial";
            // 
            // txtIndemnite
            // 
            this.txtIndemnite.Location = new System.Drawing.Point(393, 153);
            this.txtIndemnite.Name = "txtIndemnite";
            this.txtIndemnite.Size = new System.Drawing.Size(134, 20);
            this.txtIndemnite.TabIndex = 21;
            // 
            // txtBrut
            // 
            this.txtBrut.Location = new System.Drawing.Point(149, 209);
            this.txtBrut.Name = "txtBrut";
            this.txtBrut.Size = new System.Drawing.Size(121, 20);
            this.txtBrut.TabIndex = 15;
            // 
            // lblBrut
            // 
            this.lblBrut.AutoSize = true;
            this.lblBrut.Location = new System.Drawing.Point(9, 212);
            this.lblBrut.Name = "lblBrut";
            this.lblBrut.Size = new System.Drawing.Size(108, 13);
            this.lblBrut.TabIndex = 20;
            this.lblBrut.Text = "Salaire brut mensuel :";
            // 
            // cbxService
            // 
            this.cbxService.FormattingEnabled = true;
            this.cbxService.Location = new System.Drawing.Point(149, 179);
            this.cbxService.Name = "cbxService";
            this.cbxService.Size = new System.Drawing.Size(121, 21);
            this.cbxService.TabIndex = 14;
            // 
            // cbxStatut
            // 
            this.cbxStatut.FormattingEnabled = true;
            this.cbxStatut.Location = new System.Drawing.Point(149, 146);
            this.cbxStatut.Name = "cbxStatut";
            this.cbxStatut.Size = new System.Drawing.Size(121, 21);
            this.cbxStatut.TabIndex = 13;
            // 
            // txtEcole
            // 
            this.txtEcole.Location = new System.Drawing.Point(393, 124);
            this.txtEcole.Name = "txtEcole";
            this.txtEcole.Size = new System.Drawing.Size(134, 20);
            this.txtEcole.TabIndex = 19;
            // 
            // txtInterim
            // 
            this.txtInterim.Location = new System.Drawing.Point(393, 92);
            this.txtInterim.Name = "txtInterim";
            this.txtInterim.Size = new System.Drawing.Size(134, 20);
            this.txtInterim.TabIndex = 18;
            // 
            // cbxFonction
            // 
            this.cbxFonction.FormattingEnabled = true;
            this.cbxFonction.Location = new System.Drawing.Point(149, 117);
            this.cbxFonction.Name = "cbxFonction";
            this.cbxFonction.Size = new System.Drawing.Size(121, 21);
            this.cbxFonction.TabIndex = 12;
            // 
            // cbxQualif
            // 
            this.cbxQualif.FormattingEnabled = true;
            this.cbxQualif.Location = new System.Drawing.Point(149, 85);
            this.cbxQualif.Name = "cbxQualif";
            this.cbxQualif.Size = new System.Drawing.Size(121, 21);
            this.cbxQualif.TabIndex = 11;
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(366, 57);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(161, 21);
            this.cbxMotif.TabIndex = 17;
            // 
            // cbxTypeContrat
            // 
            this.cbxTypeContrat.FormattingEnabled = true;
            this.cbxTypeContrat.Location = new System.Drawing.Point(149, 56);
            this.cbxTypeContrat.Name = "cbxTypeContrat";
            this.cbxTypeContrat.Size = new System.Drawing.Size(121, 21);
            this.cbxTypeContrat.TabIndex = 10;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(110, 22);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(160, 20);
            this.dtpDebut.TabIndex = 9;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(366, 23);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(161, 20);
            this.dtpFin.TabIndex = 16;
            // 
            // lblInterim
            // 
            this.lblInterim.AutoSize = true;
            this.lblInterim.Location = new System.Drawing.Point(281, 93);
            this.lblInterim.Name = "lblInterim";
            this.lblInterim.Size = new System.Drawing.Size(92, 13);
            this.lblInterim.TabIndex = 11;
            this.lblInterim.Text = "Agence d\'Intérim :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(281, 59);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 10;
            this.lblMotif.Text = "Motif :";
            // 
            // lblFinContrat
            // 
            this.lblFinContrat.AutoSize = true;
            this.lblFinContrat.Location = new System.Drawing.Point(281, 24);
            this.lblFinContrat.Name = "lblFinContrat";
            this.lblFinContrat.Size = new System.Drawing.Size(79, 13);
            this.lblFinContrat.TabIndex = 9;
            this.lblFinContrat.Text = "Fin de Contrat :";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(9, 182);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 8;
            this.lblService.Text = "Service :";
            // 
            // lblEcole
            // 
            this.lblEcole.AutoSize = true;
            this.lblEcole.Location = new System.Drawing.Point(281, 124);
            this.lblEcole.Name = "lblEcole";
            this.lblEcole.Size = new System.Drawing.Size(40, 13);
            this.lblEcole.TabIndex = 7;
            this.lblEcole.Text = "Ecole :";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(10, 149);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(41, 13);
            this.lblStatut.TabIndex = 5;
            this.lblStatut.Text = "Statut :";
            // 
            // lblIndemnite
            // 
            this.lblIndemnite.AutoSize = true;
            this.lblIndemnite.Location = new System.Drawing.Point(281, 155);
            this.lblIndemnite.Name = "lblIndemnite";
            this.lblIndemnite.Size = new System.Drawing.Size(64, 13);
            this.lblIndemnite.TabIndex = 4;
            this.lblIndemnite.Text = "Indémnités :";
            // 
            // lblFonction
            // 
            this.lblFonction.AutoSize = true;
            this.lblFonction.Location = new System.Drawing.Point(9, 118);
            this.lblFonction.Name = "lblFonction";
            this.lblFonction.Size = new System.Drawing.Size(54, 13);
            this.lblFonction.TabIndex = 3;
            this.lblFonction.Text = "Fonction :";
            // 
            // lblQualif
            // 
            this.lblQualif.AutoSize = true;
            this.lblQualif.Location = new System.Drawing.Point(9, 88);
            this.lblQualif.Name = "lblQualif";
            this.lblQualif.Size = new System.Drawing.Size(120, 13);
            this.lblQualif.TabIndex = 2;
            this.lblQualif.Text = "Qualification Principale :";
            // 
            // lblTypeContrat
            // 
            this.lblTypeContrat.AutoSize = true;
            this.lblTypeContrat.Location = new System.Drawing.Point(9, 56);
            this.lblTypeContrat.Name = "lblTypeContrat";
            this.lblTypeContrat.Size = new System.Drawing.Size(89, 13);
            this.lblTypeContrat.TabIndex = 1;
            this.lblTypeContrat.Text = "Type de Contrat :";
            // 
            // lblDebutContrat
            // 
            this.lblDebutContrat.AutoSize = true;
            this.lblDebutContrat.Location = new System.Drawing.Point(9, 24);
            this.lblDebutContrat.Name = "lblDebutContrat";
            this.lblDebutContrat.Size = new System.Drawing.Size(94, 13);
            this.lblDebutContrat.TabIndex = 0;
            this.lblDebutContrat.Text = "Début de Contrat :";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(17, 24);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(37, 20);
            this.txtMat.TabIndex = 0;
            // 
            // cbxCivil
            // 
            this.cbxCivil.FormattingEnabled = true;
            this.cbxCivil.Location = new System.Drawing.Point(68, 24);
            this.cbxCivil.Name = "cbxCivil";
            this.cbxCivil.Size = new System.Drawing.Size(44, 21);
            this.cbxCivil.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(127, 25);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(129, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(272, 26);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(127, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // cbxSitFam
            // 
            this.cbxSitFam.FormattingEnabled = true;
            this.cbxSitFam.Location = new System.Drawing.Point(418, 25);
            this.cbxSitFam.Name = "cbxSitFam";
            this.cbxSitFam.Size = new System.Drawing.Size(121, 21);
            this.cbxSitFam.TabIndex = 4;
            // 
            // txtAdress1
            // 
            this.txtAdress1.Location = new System.Drawing.Point(12, 83);
            this.txtAdress1.Name = "txtAdress1";
            this.txtAdress1.Size = new System.Drawing.Size(164, 20);
            this.txtAdress1.TabIndex = 5;
            // 
            // txtAdress2
            // 
            this.txtAdress2.Location = new System.Drawing.Point(182, 83);
            this.txtAdress2.Name = "txtAdress2";
            this.txtAdress2.Size = new System.Drawing.Size(161, 20);
            this.txtAdress2.TabIndex = 6;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(350, 83);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(68, 20);
            this.txtCP.TabIndex = 7;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(431, 83);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(108, 20);
            this.txtVille.TabIndex = 8;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(346, 377);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(469, 377);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FrmAjoutCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 406);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtAdress2);
            this.Controls.Add(this.txtAdress1);
            this.Controls.Add(this.cbxSitFam);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.cbxCivil);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.gbxContrat);
            this.Controls.Add(this.lblSitFam);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblAdress2);
            this.Controls.Add(this.lblAdress1);
            this.Controls.Add(this.lblCivil);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblMat);
            this.Name = "FrmAjoutCollaborateur";
            this.Text = "Enregistrer un nouveau Collaborateur";
            this.Load += new System.EventHandler(this.Enregistrer_un_nouveau_ollaborateur_Load);
            this.gbxContrat.ResumeLayout(false);
            this.gbxContrat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblCivil;
        private System.Windows.Forms.Label lblAdress1;
        private System.Windows.Forms.Label lblAdress2;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblSitFam;
        private System.Windows.Forms.GroupBox gbxContrat;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblInterim;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblFinContrat;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblEcole;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblIndemnite;
        private System.Windows.Forms.Label lblFonction;
        private System.Windows.Forms.Label lblQualif;
        private System.Windows.Forms.Label lblTypeContrat;
        private System.Windows.Forms.Label lblDebutContrat;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.ComboBox cbxCivil;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox cbxSitFam;
        private System.Windows.Forms.TextBox txtAdress1;
        private System.Windows.Forms.TextBox txtAdress2;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.ComboBox cbxTypeContrat;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.ComboBox cbxQualif;
        private System.Windows.Forms.ComboBox cbxFonction;
        private System.Windows.Forms.TextBox txtInterim;
        private System.Windows.Forms.TextBox txtEcole;
        private System.Windows.Forms.ComboBox cbxStatut;
        private System.Windows.Forms.ComboBox cbxService;
        private System.Windows.Forms.TextBox txtBrut;
        private System.Windows.Forms.Label lblBrut;
        private System.Windows.Forms.TextBox txtIndemnite;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
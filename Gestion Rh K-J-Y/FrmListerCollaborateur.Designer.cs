﻿namespace Gestion_Rh_K_J_Y
{
    partial class FrmListerCollaborateur
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
            this.components = new System.ComponentModel.Container();
            this.dgvListCollaborateurs = new System.Windows.Forms.DataGridView();
            this.ColumnMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEtatcivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodeP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdresse1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdresse2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSalaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSituationF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnLancer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtAfficherTout = new System.Windows.Forms.RadioButton();
            this.rbtNom = new System.Windows.Forms.RadioButton();
            this.rbtService = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCollaborateurs)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListCollaborateurs
            // 
            this.dgvListCollaborateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCollaborateurs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMat,
            this.ColumnEtatcivil,
            this.ColumnNom,
            this.ColumnPrénom,
            this.ColumnCodeP,
            this.ColumnVille,
            this.ColumnAdresse1,
            this.ColumnAdresse2,
            this.ColumnSalaire,
            this.ColumnQualification,
            this.ColumnSituationF,
            this.ColumnService});
            this.dgvListCollaborateurs.Location = new System.Drawing.Point(50, 92);
            this.dgvListCollaborateurs.Name = "dgvListCollaborateurs";
            this.dgvListCollaborateurs.Size = new System.Drawing.Size(544, 137);
            this.dgvListCollaborateurs.TabIndex = 0;
            this.dgvListCollaborateurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ColumnMat
            // 
            this.ColumnMat.HeaderText = "Matricule";
            this.ColumnMat.Name = "ColumnMat";
            // 
            // ColumnEtatcivil
            // 
            this.ColumnEtatcivil.HeaderText = "Etat civil";
            this.ColumnEtatcivil.Name = "ColumnEtatcivil";
            // 
            // ColumnNom
            // 
            this.ColumnNom.HeaderText = "Nom";
            this.ColumnNom.Name = "ColumnNom";
            // 
            // ColumnPrénom
            // 
            this.ColumnPrénom.HeaderText = "Prénom";
            this.ColumnPrénom.Name = "ColumnPrénom";
            // 
            // ColumnCodeP
            // 
            this.ColumnCodeP.HeaderText = "Code postal";
            this.ColumnCodeP.Name = "ColumnCodeP";
            // 
            // ColumnVille
            // 
            this.ColumnVille.HeaderText = "Ville";
            this.ColumnVille.Name = "ColumnVille";
            // 
            // ColumnAdresse1
            // 
            this.ColumnAdresse1.HeaderText = "Adresse 1";
            this.ColumnAdresse1.Name = "ColumnAdresse1";
            // 
            // ColumnAdresse2
            // 
            this.ColumnAdresse2.HeaderText = "Adresse 2";
            this.ColumnAdresse2.Name = "ColumnAdresse2";
            // 
            // ColumnSalaire
            // 
            this.ColumnSalaire.HeaderText = "Salaire";
            this.ColumnSalaire.Name = "ColumnSalaire";
            // 
            // ColumnQualification
            // 
            this.ColumnQualification.HeaderText = "Qualification";
            this.ColumnQualification.Name = "ColumnQualification";
            // 
            // ColumnSituationF
            // 
            this.ColumnSituationF.HeaderText = "Situation Familiale";
            this.ColumnSituationF.Name = "ColumnSituationF";
            // 
            // ColumnService
            // 
            this.ColumnService.HeaderText = "Service";
            this.ColumnService.Name = "ColumnService";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(12, 9);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(60, 13);
            this.lblRecherche.TabIndex = 1;
            this.lblRecherche.Text = "Recherche";
            this.lblRecherche.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(105, 6);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(374, 20);
            this.txtRecherche.TabIndex = 2;
            this.txtRecherche.TextChanged += new System.EventHandler(this.txtRecherche_TextChanged);
            // 
            // btnLancer
            // 
            this.btnLancer.Location = new System.Drawing.Point(506, 4);
            this.btnLancer.Name = "btnLancer";
            this.btnLancer.Size = new System.Drawing.Size(75, 23);
            this.btnLancer.TabIndex = 3;
            this.btnLancer.Text = "Lancer";
            this.btnLancer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtAfficherTout);
            this.groupBox1.Controls.Add(this.rbtNom);
            this.groupBox1.Controls.Add(this.rbtService);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(66, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tri";
            // 
            // rbtAfficherTout
            // 
            this.rbtAfficherTout.AutoSize = true;
            this.rbtAfficherTout.Location = new System.Drawing.Point(321, 19);
            this.rbtAfficherTout.Name = "rbtAfficherTout";
            this.rbtAfficherTout.Size = new System.Drawing.Size(86, 17);
            this.rbtAfficherTout.TabIndex = 3;
            this.rbtAfficherTout.TabStop = true;
            this.rbtAfficherTout.Text = "Afficher Tout";
            this.rbtAfficherTout.UseVisualStyleBackColor = true;
            // 
            // rbtNom
            // 
            this.rbtNom.AutoSize = true;
            this.rbtNom.Location = new System.Drawing.Point(119, 19);
            this.rbtNom.Name = "rbtNom";
            this.rbtNom.Size = new System.Drawing.Size(47, 17);
            this.rbtNom.TabIndex = 1;
            this.rbtNom.TabStop = true;
            this.rbtNom.Text = "Nom";
            this.rbtNom.UseVisualStyleBackColor = true;
            // 
            // rbtService
            // 
            this.rbtService.AutoSize = true;
            this.rbtService.Location = new System.Drawing.Point(16, 19);
            this.rbtService.Name = "rbtService";
            this.rbtService.Size = new System.Drawing.Size(61, 17);
            this.rbtService.TabIndex = 0;
            this.rbtService.TabStop = true;
            this.rbtService.Text = "Service";
            this.rbtService.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ajouter Collaborateur";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(437, 235);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(534, 235);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmListerCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 283);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLancer);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.dgvListCollaborateurs);
            this.Name = "FrmListerCollaborateur";
            this.Text = "Lancer";
            this.Load += new System.EventHandler(this.FrmLister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCollaborateurs)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListCollaborateurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEtatcivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodeP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdresse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdresse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSituationF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnService;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtNom;
        private System.Windows.Forms.RadioButton rbtService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.RadioButton rbtAfficherTout;
        private System.Windows.Forms.Button btnFermer;
    }
}
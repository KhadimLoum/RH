namespace Gestion_Rh_K_J_Y
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnLancer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtAfficherTout = new System.Windows.Forms.RadioButton();
            this.rbtNom = new System.Windows.Forms.RadioButton();
            this.rbService = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.rbEtatCivile = new System.Windows.Forms.RadioButton();
            this.dgvListCollaborateurs = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCollaborateurs)).BeginInit();
            this.SuspendLayout();
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
            this.btnLancer.Click += new System.EventHandler(this.btnLancer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEtatCivile);
            this.groupBox1.Controls.Add(this.rbtAfficherTout);
            this.groupBox1.Controls.Add(this.rbtNom);
            this.groupBox1.Controls.Add(this.rbService);
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
            this.rbtAfficherTout.CheckedChanged += new System.EventHandler(this.rbtAfficherTout_CheckedChanged);
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
            // rbService
            // 
            this.rbService.AutoSize = true;
            this.rbService.Location = new System.Drawing.Point(16, 19);
            this.rbService.Name = "rbService";
            this.rbService.Size = new System.Drawing.Size(61, 17);
            this.rbService.TabIndex = 0;
            this.rbService.TabStop = true;
            this.rbService.Text = "Service";
            this.rbService.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ajouter Collaborateur";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(471, 508);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 5;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(573, 495);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 6;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // rbEtatCivile
            // 
            this.rbEtatCivile.AutoSize = true;
            this.rbEtatCivile.Location = new System.Drawing.Point(189, 19);
            this.rbEtatCivile.Name = "rbEtatCivile";
            this.rbEtatCivile.Size = new System.Drawing.Size(66, 17);
            this.rbEtatCivile.TabIndex = 4;
            this.rbEtatCivile.TabStop = true;
            this.rbEtatCivile.Text = "Etat Civil";
            this.rbEtatCivile.UseVisualStyleBackColor = true;
            // 
            // dgvListCollaborateurs
            // 
            this.dgvListCollaborateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCollaborateurs.Location = new System.Drawing.Point(94, 92);
            this.dgvListCollaborateurs.Name = "dgvListCollaborateurs";
            this.dgvListCollaborateurs.Size = new System.Drawing.Size(852, 377);
            this.dgvListCollaborateurs.TabIndex = 7;
            this.dgvListCollaborateurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCollaborateurs_CellContentClick_1);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // FrmListerCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.dgvListCollaborateurs);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLancer);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Name = "FrmListerCollaborateur";
            this.Text = "Lancer";
            this.Load += new System.EventHandler(this.FrmLister_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCollaborateurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnLancer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtNom;
        private System.Windows.Forms.RadioButton rbService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.RadioButton rbtAfficherTout;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.RadioButton rbEtatCivile;
        private System.Windows.Forms.DataGridView dgvListCollaborateurs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}
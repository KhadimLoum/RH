namespace Gestion_Rh_K_J_Y
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterDesCollaborateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCollaborateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCollaborateursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rHToolStripMenuItem,
            this.connexionToolStripMenuItem,
            this.listeDesCollaborateursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rHToolStripMenuItem
            // 
            this.rHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterDesCollaborateursToolStripMenuItem});
            this.rHToolStripMenuItem.Name = "rHToolStripMenuItem";
            this.rHToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.rHToolStripMenuItem.Text = "RH";
            this.rHToolStripMenuItem.Click += new System.EventHandler(this.rHToolStripMenuItem_Click_1);
            // 
            // ajouterDesCollaborateursToolStripMenuItem
            // 
            this.ajouterDesCollaborateursToolStripMenuItem.Name = "ajouterDesCollaborateursToolStripMenuItem";
            this.ajouterDesCollaborateursToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ajouterDesCollaborateursToolStripMenuItem.Text = "Ajouter des collaborateurs";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconnexionToolStripMenuItem,
            this.déconnexionToolStripMenuItem1});
            this.connexionToolStripMenuItem.Enabled = false;
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.connexionToolStripMenuItem.Text = "Connexion";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.déconnexionToolStripMenuItem.Text = "Changer Utilisateur";
            // 
            // déconnexionToolStripMenuItem1
            // 
            this.déconnexionToolStripMenuItem1.Name = "déconnexionToolStripMenuItem1";
            this.déconnexionToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.déconnexionToolStripMenuItem1.Text = "Déconnexion";
            // 
            // listeDesCollaborateursToolStripMenuItem
            // 
            this.listeDesCollaborateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCollaborateursToolStripMenuItem1});
            this.listeDesCollaborateursToolStripMenuItem.Name = "listeDesCollaborateursToolStripMenuItem";
            this.listeDesCollaborateursToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.listeDesCollaborateursToolStripMenuItem.Text = "Affichage";
            this.listeDesCollaborateursToolStripMenuItem.Click += new System.EventHandler(this.listeDesCollaborateursToolStripMenuItem_Click);
            // 
            // listeDesCollaborateursToolStripMenuItem1
            // 
            this.listeDesCollaborateursToolStripMenuItem1.Name = "listeDesCollaborateursToolStripMenuItem1";
            this.listeDesCollaborateursToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.listeDesCollaborateursToolStripMenuItem1.Text = "Liste des Collaborateurs";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 596);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Page d\'accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterDesCollaborateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCollaborateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCollaborateursToolStripMenuItem1;
    }
}
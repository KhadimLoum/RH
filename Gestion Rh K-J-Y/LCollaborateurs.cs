using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gestion_Rh_K_J_Y
{
    public class LCollaborateurs
    {
        /// <summary>
        /// datatable de 10 colonnes pour restituer la liste des Collaborateurs
        /// </summary>
        private DataTable dtCollaborateurs;
        internal static object listCollaborateur;

        public static MDI MDI { get; internal set; }

        public LCollaborateurs()
        {
            //prépare la datatable pour restituer la liste des Collaborateurs
            dtCollaborateurs = new DataTable();
            //ajouter à la datatable 10 colonnes personnalisées
            this.dtCollaborateurs.Columns.Add(new DataColumn("Matricule", typeof(System.Int32)));
            this.dtCollaborateurs.Columns.Add(new DataColumn("Etat_Civil", typeof(System.String)));
            this.dtCollaborateurs.Columns.Add(new DataColumn("Nom", typeof(System.String)));
            this.dtCollaborateurs.Columns.Add(new DataColumn("Prénom", typeof(System.String)));
            this.dtCollaborateurs.Columns.Add(new DataColumn("Service", typeof(System.Boolean)));
            this.dtCollaborateurs.Columns.Add(new DataColumn("Adresse 1", typeof(System.String)));
            this.dtCollaborateurs.Columns.Add(new DataColumn("Adresse 2", typeof(System.String)));
            this.dtCollaborateurs.Columns.Add(new DataColumn("Code Postal", typeof(System.String)));
            this.dtCollaborateurs.Columns.Add(new DataColumn("Ville", typeof(System.String)));
            this.dtCollaborateurs.Columns.Add(new DataColumn("Situation de Famille", typeof(System.String)));

        }

        public void Ajouter(Collaborateur uncollabo)
        {
            Donnees.listCollaborateur.Add(uncollabo.MATRICULE, uncollabo);
        }

        public void Supprimer(Collaborateur uncollabo)
        {
            Donnees.listCollaborateur.Remove(uncollabo.MATRICULE);
        }

        public void Supprimer(Int32 unNumcollaborateur)
        {
            if (Donnees.listCollaborateur.ContainsKey(unNumcollaborateur))
            {
                Donnees.listCollaborateur.Remove(unNumcollaborateur);
            }
            else
            {
                throw new Exception("Erreur : numéro Collaborateur non trouvé dans la collection");
            }
        }
        public void Modifier(Collaborateur uncollabo)
        {
            Donnees.listCollaborateur[uncollabo.MATRICULE] = uncollabo;
        }

        public Collaborateur RechercherClient(Int32 unMatcollaborateur)
        {
            Collaborateur lecollabo;
            lecollabo = Donnees.listCollaborateur[unMatcollaborateur] as Collaborateur;
            if (lecollabo == null)
            {
                throw new Exception("Aucun Collaborateur trouvé pour le Matricule Collaborateur :" + unMatcollaborateur);
            }
            else
            {

                //MessageBox.Show(lecollabo.ToString());
                return lecollabo;
            }
        }

        public DataTable ListerCollaborateur()
        {
            //permet de vider la DataTable pour la régénérer
            this.dtCollaborateurs.Clear();
            foreach (Collaborateur uncollabo in Donnees.listCollaborateur.Values)
            {
                DataRow dr;
                dr = this.dtCollaborateurs.NewRow();
                //affectation des colonnes
                dr[0] = uncollabo.MATRICULE;
                dr[1] = uncollabo.ETATCIVIL;
                dr[2] = uncollabo.NOM;
                dr[3] = uncollabo.PRENOM;
                dr[4] = uncollabo.CodePostal;
                dr[5] = uncollabo.VILLE;
                dr[6] = uncollabo.ADRESSE1;
                dr[7] = uncollabo.ADRESSE2;
                dr[8] = uncollabo.SALAIRE;
                dr[9] = uncollabo.QUALIFICATIONS;
                dr[10] = uncollabo.SITUATIONFAMILIALE;
                dr[11] = uncollabo.SERVICE;

                //ajouter la ligne à la datatable
                this.dtCollaborateurs.Rows.Add(dr);
            }
            //retourne la référence de la datatable
            return this.dtCollaborateurs;
        }

    }
}
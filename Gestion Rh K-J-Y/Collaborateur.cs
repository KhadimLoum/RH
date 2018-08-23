using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Rh_K_J_Y
{
    public class Collaborateur
    {
        
        
            private int matricule;
            private double salaire;
            private string nom;
            private string prenom;
            private string qualifications;
            private string adresse;
            private string adresse2;
            private string Ville;
            private string codePostale;
            private string service;
            private string situationFamiliale;
            private string etatCivil;
        private int Id;
        private int Mdp;

            public Collaborateur() { }
        private int MDP
        {
            get
            {
                return this.Mdp;
            }
            set
            {
                this.Mdp = value;
            }
        }

        private int ID
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }
            public int MATRICULE
            {
                get
                {
                    return this.matricule;
                }
                set
                {
                    this.matricule = value;
                }
            }

            public double SALAIRE
            {
                get
                {
                    return this.salaire;
                }
                set
                {
                    this.salaire = value;
                }
            }

            public string NOM
            {
                get
                {
                    return this.nom;
                }
                set
                {
                    this.nom = value;
                }
            }

            public string PRENOM
            {
                get
                {
                    return this.prenom;
                }
                set
                {
                    this.prenom = value;
                }
            }

            public string QUALIFICATIONS
            {
                get
                {
                    return this.qualifications;
                }
                set
                {
                    this.qualifications = value;
                }
            }
            public string ADRESSE1
            {
                get
                {
                    return this.adresse;
                }
                set
                {
                    this.adresse = value;
                }

            }
            public string ADRESSE2
            {
                get
                {
                    return this.adresse2;
                }
                set
                {
                    this.adresse2 = value;
                }

            }
            public string VILLE
            {
                get
                {
                    return this.Ville;
                }
                set
                {
                    this.Ville = value;
                }

            }
        public string CodePostal
        {
            get { return this.codePostale; }
            set
            {
                // l'appelant doit fournir un code postal valide à 5 chiffres
                Int32 i;               // variable  de boucle
                Boolean erreur = false; // indicateur erreur
                if (value.Length == 5) // 5 car. attendus : OK ==> contrôler un à un
                {
                    for (i = 0; i < value.Length; i++)  // controle caractères par boucle
                    {
                        if (!(Char.IsDigit(value[i]))) // ce n'est pas un chiffre
                        { erreur = true; }

                    } // fin de boucle controle chiffres
                    if (erreur) //on a rencontre un non-chiffre
                    {
                        // levée d'exception
                        throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide : uniquement des chiffres");
                    }
                    else
                    {
                        this.codePostale = value;  // tout est bon, on affecte l'attribut
                    }
                }
                else // il n'y a pas 5 caractères
                {
                    // levée d'exception
                    throw new Exception(value.ToString() + "\n" + "n'est pas un code postal valide : 5 chiffres, pas plus, pas moins");
                }

            }
        }

        public string SERVICE
            {
                get
                {
                    return this.service;
                }
                set
                {
                    this.service = value;
                }

            }
            public string SITUATIONFAMILIALE
            {
                get
                {
                    return this.situationFamiliale;
                }
                set
                {
                    this.situationFamiliale = value;
                }

            }
            public string ETATCIVIL
            {
                get
                {
                    return this.etatCivil;
                }
                set
                {
                    this.etatCivil = value;
                }
            }
        ///Initialise
            public Collaborateur(int mat, string etatC, string nom, string pren, string codeP, string Vil, string adr, string adr2, int sal, string qual, string situationF, string Serv,int iden,int motpasse)
            {
                this.prenom = pren;
                this.nom = nom;
                this.matricule = mat;
                this.salaire = sal;
                this.qualifications = qual;
                this.adresse = adr2;
                this.codePostale = codeP;
                this.Ville = Vil;
                this.adresse2 = adr2;
                this.situationFamiliale = situationF;
                this.service = Serv;
                this.etatCivil = etatC;
            this.Id = iden;
            this.Mdp = motpasse;
                Collaborateur c1, c2, c3, c4;
                c1 = new Collaborateur(1, "M", "Loum", "Khadim", 73000, "Orléans", "5 rue des Chapélis", "", 20000, "Boss", "Célibataire", "Administartion",2654,6547);
                c2 = new Collaborateur(2, "M", "Loum", "Khadim", 73000, "Orléans", "5 rue des Chapélis", "", 20000, "Boss", "Célibataire", "Administartion",2789,6541);
                c3 = new Collaborateur(3, "M", "Loum", "Khadim", 73000, "Orléans", "5 rue des Chapélis", "", 20000, "Boss", "Célibataire", "Administartion",2456,6325);
                c4 = new Collaborateur(4, "M", "Loum", "Khadim", 73000, "Orléans", "5 rue des Chapélis", "", 20000, "Boss", "Célibataire", "Administartion",2346,3156);

            Donnees.listCollaborateur.Add(c1.matricule, c1);
            Donnees.listCollaborateur.Add(c2.matricule, c2);
            Donnees.listCollaborateur.Add(c3.matricule, c3);
            Donnees.listCollaborateur.Add(c4.matricule, c4);

        }
        
            
            

      
    }
}

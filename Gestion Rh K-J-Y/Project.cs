using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Rh_K_J_Y
{
    class Project
    {
        private int IDproject;
        private string Nom;
        private string DateFin;
        private string DateDébut;
        public int IDPROJECT
        {
            get
            {
                return this.IDproject;
            }
            set
            {
                this.IDproject = value;
            }
        }
        public string NOM
        {
            get
            {
                return this.Nom;
            }
            set
            {
                this.Nom = value;
            }
        }
        public string DATEDEBUT
        {
            get
            {
                return this.DateDébut;
            }
            set
            {
                this.DateDébut = value;

            }

        }
        public string DATEFIN
        {
            get
            {
                return this.DateFin;
            }
            set
            {
                this.DateFin = value;
            }
        }
        Project() { }
        public Project(int IDproj, string Nom, string Dated, string Datef)
        {
            this.IDproject = IDproj;
            this.Nom = Nom;
            this.DateDébut = Dated;
            this.DateFin = Datef;
            Project p1, p2, p3, p4;
            p1 = new Project(4, "Eleveur de cochon", "01-05-2015", "05-04-2015");
            p2 = new Project(4, "Eleveur de cochon", "01-05-2015", "05-04-2015");
            p3 = new Project(4, "Eleveur de cochon", "01-05-2015", "05-04-2015");
            p4 = new Project(4, "Eleveur de cochon", "01-05-2015", "05-04-2015");
        }
        List<Project> Projec = new List<Project>(4);
    }
   
}

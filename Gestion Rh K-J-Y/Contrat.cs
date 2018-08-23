using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Rh_K_J_Y
{
    public class Contrat
    {
        private string IdProject;
        private string DatedébutContrat;
        private string DatefinContrat;
        private string Motif;
        private string TypeContrat;
        private string Service;

       
        public string IDPROJECT
        {
            get
            {
                return this.IdProject;
            }
            set
            {
                this.IdProject = value;
            }
        }
       
        public string SERVICE
        {
            get
            {
                return this.Service;
            }
            set
            {
                this.Service = value;
            }
        }
        public string TYPECONTRAT
        {
            get
            {
                return this.TypeContrat;
            }
            set
            {
                this.TypeContrat = value;

            }
        }
        public string MOTIF
        {
            get
            {
                return this.Motif;
            }
            set
            {
                this.Motif = value;
            }
        }
        public string DATEDEBUT
        {
            get
            {
                return this.DatedébutContrat;

            }
            set
            {
                this.DatedébutContrat = value;
            }
        }
        public string DATEFIN
        {
            get
            {
                return this.DatefinContrat;
            }
            set
            {
                this.DatefinContrat = value;
            }
        }
        public Contrat() { }
        public Contrat( string IDproj,string Service,string TypeContrat,string DateD,string DateF,string Motif)
        {
            
            this.IdProject = IDproj;
            this.Service = Service;
            this.DatedébutContrat = DateD;
            this.DatefinContrat = DateF;
            this.Motif = Motif;
            Contrat c1, c2, c3, c4;
            c1 = new Contrat("1", "Serveu", "r","CDD", "05-05-2015", "05-04-2014");
            c2 = new Contrat("1", "Serveu", "r", "CDD", "05-05-2015", "05-04-2014");
            c3 = new Contrat("1", "Serveu", "r", "CDD", "05-05-2015", "05-04-2014");
            c4 = new Contrat("1", "Serveu", "r", "CDD", "05-05-2015", "05-04-2014");
        }
        List<Contrat> Collabo = new List<Contrat>(4);
    }
    
}
        
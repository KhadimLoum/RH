﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Rh_K_J_Y
{
    class Donnees
    {
        public static System.Windows.Forms.Form MDI;

        public static LCollaborateurs lcl  = new LCollaborateurs();
        public static Collaborateur Lcl = new Collaborateur();
        public static Collaborateur Collabo = new Collaborateur();
        public static SortedList<Int32, Collaborateur> listCollaborateur = new SortedList<Int32, Collaborateur>();
      
    }
}


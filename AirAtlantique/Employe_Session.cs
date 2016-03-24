using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique
{
    class Employe_Session
    {
        public virtual Employe Employes { get; set; }

        public virtual Session Sessions { get; set; }

        public bool Valider { get; set; }
    }
}

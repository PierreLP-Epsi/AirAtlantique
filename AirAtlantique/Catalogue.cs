using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique
{
    class Catalogue
    {
        public virtual ICollection<Formation> Formations { get; set; }
    }
}

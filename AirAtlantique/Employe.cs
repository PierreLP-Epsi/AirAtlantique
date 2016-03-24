using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique
{
    class Employe
    {
        [Key]
        public int ID { get; set; }

        public String Nom { get; set; }

        public string Prenom { get; set; }

        public Metier Metier { get; set; }

        public virtual ICollection<Formation> Formations { get; set; }

    }
}

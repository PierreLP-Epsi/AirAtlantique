using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique
{
    class Session
    {
        [Key]
        public int ID { get; set; }

        public int NbrPlaceTotal { get; set; }

       

        public String Lieu { get; set; }

        public int Duree { get; set; }

        public bool Valider { get; set; }
    }
}

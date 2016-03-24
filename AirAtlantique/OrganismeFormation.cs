using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique
{
    class OrganismeFormation
    {
        [Key]
        public int ID { get; set; }

        public String Nom { get; set; }

        public string Reference { get; set; }
    }
}

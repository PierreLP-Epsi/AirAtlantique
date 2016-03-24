﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique
{
    class Formation
    {
        [Key]
        public int ID { get; set; }

        public string Description { get; set; }

        public int Duree { get; set; }

        public int DureeDeValidation { get; set; }

        public virtual ICollection<Employe> Employes { get; set; }

        public virtual ICollection<Catalogue> Catalogues { get; set; }
    }
}

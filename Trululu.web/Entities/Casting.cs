using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trululu.web.Entities
{
    public class Casting
    {
        public int Id { get; set; }
        public string libelle { get; set; }
        public int age_min { get; set; }
        public int age_max { get; set; }
        public string description_poste { get; set; }
        public string description_profil { get; set; }
    }
}

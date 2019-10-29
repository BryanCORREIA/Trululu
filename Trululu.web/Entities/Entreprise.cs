using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trululu.web.Entities
{
    public class Entreprise
    {
        public int Id { get; set; }
        public string libelle { get; set; }
        public int telephone { get; set; }
        public string email { get; set; }
        public string adresse { get; set; }
    }
}

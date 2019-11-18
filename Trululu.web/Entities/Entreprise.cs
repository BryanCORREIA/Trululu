using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trululu.web.Entities
{
    public class Entreprise
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public string Adresse { get; set; }
    }
}

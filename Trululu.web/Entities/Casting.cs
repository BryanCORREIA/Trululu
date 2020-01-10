using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trululu.web.Entities
{
    public class Casting
    {
        public int Id { get; set; }
        public string Wording { get; set; }
        public int AgeMin { get; set; }
        public int AgeMax { get; set; }
        public string DescriptionPost { get; set; }
        public string DescriptionProfile { get; set; }
    }
}

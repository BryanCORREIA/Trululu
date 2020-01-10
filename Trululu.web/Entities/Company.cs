using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trululu.web.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Wording { get; set; }
        public int Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
    }
}

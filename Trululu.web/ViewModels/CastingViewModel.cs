using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trululu.web.ViewModels
{
    public class CastingViewModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Wording { get; set; }
        [Required]
        public int AgeMin { get; set; }
        [Required]
        public int AgeMax { get; set; }
        [Required]
        public String DescriptionPost { get; set; }
        [Required]
        public string DescriptionProfile { get; set; }
    }
}

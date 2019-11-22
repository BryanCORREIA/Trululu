using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trululu.web.ViewModels
{
    public class InscriptionViewModel 
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, ErrorMessage = "Trop long")]
        public string Email { get; set; }
        [Required]
        public string Telephone { get; set;  }
        [Required]
        public DateTime DateNaissance { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public string MotDePasse { get; set; }
    }
}

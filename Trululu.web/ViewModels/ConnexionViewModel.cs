﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trululu.web.ViewModels
{
    public class ConnexionViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, ErrorMessage = "Trop long")]
        public string Email { get; set; }
        [Required]
        public string MotDePasse { get; set; }
    }
}

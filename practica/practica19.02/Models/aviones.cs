using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace practica19._02.Models
{

    public class aviones
    {
        [Key]
        public string codigo { get; set; }
        [Required]
        [Display(Name = "Ingrese nombre correcto")]
        public string base1 {get; set;}
        

    }
}

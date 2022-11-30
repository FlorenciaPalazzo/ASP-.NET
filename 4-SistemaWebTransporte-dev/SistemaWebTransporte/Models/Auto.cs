using SistemaWebTransporte.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaWebTransporte.Models
{
    [Table("Auto")]
    public class Auto
    {
        
        [Required]
        public int Id { get; set; }

        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        [CheckValidYear]
        [DisplayName("Año")]
        public int Anio { get; set; }
        [Required]
        public string Color { get; set; }

    }
}
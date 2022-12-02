using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace WebElReyCan.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [DisplayName("Nombre Dueño")]
        public string NombreDuenio { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Celular { get; set; }
    }
}
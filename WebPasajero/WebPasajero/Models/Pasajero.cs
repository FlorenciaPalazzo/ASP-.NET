using System;
using System.ComponentModel;

namespace WebPasajero.Models
{
    public class Pasajero
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [DisplayName("Fecha de Nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }
    }
}

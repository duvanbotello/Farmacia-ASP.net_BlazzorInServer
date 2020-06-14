using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaBlazorWebAssam.Data
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNac { get; set; }
    }
}

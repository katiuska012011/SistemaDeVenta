using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVenta.Models
{
    public class Empleado
    {
        public int id { get; set; }
        public String Nombre  { get; set; }
        public String Telefono { get; set; }
        public String  Correo { get; set; }
        public String Clave { get; set; }
    }
}

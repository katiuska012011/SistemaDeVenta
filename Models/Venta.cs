using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVenta.Models
{
    public class Venta
    {
        public int id { get; set; }
        public String CorreoCliente { get; set; }
        public float Precio { get; set; }

    }
}

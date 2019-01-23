using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVenta.Models
{
    public class Producto
    {

        public int id { get; set; }
        public String Nombre{ get; set; }
        public String Descripcion { get; set; }
        public String Precio{ get; set; }
    }
}

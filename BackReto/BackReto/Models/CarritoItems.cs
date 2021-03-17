using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackReto.Models
{
    public class CarritoItems
    {
        public int idCarritoItems { get; set; }
        public int idCarrito { get; set; }
        public int idProducto { get; set; }
        public int Cantidad { get; set; }

    }
}

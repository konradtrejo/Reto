using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackReto.Models
{
    public class Carrito
    {
        public int idCarrito { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

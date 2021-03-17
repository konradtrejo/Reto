using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackReto.Models
{
    public class OrdenPedido
    {
        public string idOrdenPedido { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal Total { get; set; }

    }
}

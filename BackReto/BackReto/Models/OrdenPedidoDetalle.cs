using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackReto.Models
{
    public class OrdenPedidoDetalle
    {
        public int idOrdenPedidoDetalle { get; set; }
        public int IdOrdenPedido { get; set; }
        public int ProductId { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

    }
}

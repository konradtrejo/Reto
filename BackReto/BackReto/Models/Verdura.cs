using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BackReto.Models
{
    public class Verdura
    {
        [Key]
        public int idVerdura { get; set; }
        public string Categoria { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string PathFileName { get; set; }
    }
}

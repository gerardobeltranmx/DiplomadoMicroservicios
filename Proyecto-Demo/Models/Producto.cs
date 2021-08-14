using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Demo.Models
{
    
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public decimal PrecioVenta { get; set; }
   //     public decimal PrecioCompra { get; set; }
     //   public decimal Descuento { get; set; }
       // public int Estado { get; set; }
        //public int otro { get; set; }
        //public int unomas { get; set; }

    }
}

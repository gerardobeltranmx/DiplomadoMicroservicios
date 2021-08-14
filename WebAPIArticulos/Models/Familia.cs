using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIArticulos.Models
{
    public class Familia
    {
        [Key]
        public int FamiliaId { get; set; }
        public string Descripcion { get; set; }

    }
}

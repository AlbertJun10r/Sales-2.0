using Sales_System_2._0.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System_2._0.Domain.Entities
{
    public class Usuario : Person
    {
        [Key]
        public int idUsuario { get; set; }
        public String? nombre{ get; set; }
        public int Telefono { get; set; }
        public int? idRol { get; set; }
        public String? urlFoto { get; set; }
        public String? nombreFoto { get; set; }
    }
}

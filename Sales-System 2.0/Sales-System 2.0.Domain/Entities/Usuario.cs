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
        public int Id { get; set; }
        public String? Nombre{ get; set; }
        public int Telefono { get; set; }
        public int? IdRol { get; set; }
        public String? UrlFoto { get; set; }
        public String? NombreFoto { get; set; }
    }
}

using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class Rol : BaseEntity
    {
        [Key]
        public int IdRol { get; set; }
        public String? Descripcion { get; set; }


    }
}

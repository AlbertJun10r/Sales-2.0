using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class MenuRol : BaseEntity
    {
        [Key]
        public int idMenuRol { get; set; }
        public int idMenu { get; set; }
        public int idRol { get; set; }

    }
}

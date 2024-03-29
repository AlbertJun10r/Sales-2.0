
using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Key]
        public int IdCategoria { get; set; }
        public String? Descripcion { get; set; }
        public List<Producto> Productos { get; set; }


    }
}

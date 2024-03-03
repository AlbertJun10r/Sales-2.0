
using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Key]
        public int idCategoria { get; set; }
        public String? descripcion { get; set; }
        public List<Producto> productos { get; set; }


    }
}

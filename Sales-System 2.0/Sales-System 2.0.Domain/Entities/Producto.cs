using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class Producto : BaseEntity
    {
        [Key]
        public int idProducto { get; set; }
        public String? codigoBarra { get; set; }
        public String? marca { get; set; }
        public String? descripcion { get; set; }
        public int? idCategoria { get; set; }
        public int? stock { get; set; }
        public String urlImagen { get; set; }
        public String? nombreImagen { get; set; }
        public decimal precio { get; set; }

        public Category categoria { get; set; }

    }
}

using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class Producto : BaseEntity
    {
        [Key]
        public int IdProducto { get; set; }
        public String? CodigoBarra { get; set; }
        public String? Marca { get; set; }
        public String? Descripcion { get; set; }
        public int? IdCategoria { get; set; }
        public int? Stock { get; set; }
        public String UrlImagen { get; set; }
        public String? NombreImagen { get; set; }
        public decimal Precio { get; set; }

        public Category Categoria { get; set; }

    }
}

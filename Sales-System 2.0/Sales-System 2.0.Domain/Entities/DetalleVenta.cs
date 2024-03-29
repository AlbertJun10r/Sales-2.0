using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class DetalleVenta : BaseEntity
    {
        [Key]
        public int IdDetalleVenta { get; set; }
        public int? IdVenta { get; set; }
        public int? IdProducto { get; set; }
        public String? MarcaProducto { get; set; }
        public String? DescripcionProducto { get; set; }
        public String? CategoriaProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Total { get; set; }


    }
}

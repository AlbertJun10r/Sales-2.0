using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class DetalleVenta : BaseEntity
    {
        [Key]
        public int idDetalleVenta { get; set; }
        public int? idVenta { get; set; }
        public int? idProducto { get; set; }
        public String? MarcaProducto { get; set; }
        public String? descripcionProducto { get; set; }
        public String? categoriaProducto { get; set; }
        public int cantidad { get; set; }
        public decimal? precio { get; set; }
        public decimal? total { get; set; }


    }
}

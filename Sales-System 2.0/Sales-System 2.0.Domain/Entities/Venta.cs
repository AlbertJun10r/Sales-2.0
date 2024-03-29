using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class Venta : BaseEntity
    {
        [Key]
        public int IdVenta { get; set; }
        public String? NumeroVenta { get; set; }
        public int IdTipoDocumentoVenta { get; set; }
        public int IdUsuario { get; set; }
        public String? Documentocliente { get; set; }
        public String? Nombrecliente { get; set; }
        public Decimal? Subtotal { get; set; }
        public Decimal? ImpuestoTotal { get; set; }
        public Decimal? Total { get; set; }


    }
}

using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class Venta : BaseEntity
    {
        [Key]
        public int idVenta { get; set; }
        public String? NumeroVenta { get; set; }
        public int idTipoDocumentoVenta { get; set; }
        public int idUsuario { get; set; }
        public String? documentocliente { get; set; }
        public String? nombrecliente { get; set; }
        public Decimal? subtotal { get; set; }
        public Decimal? impuestoTotal { get; set; }
        public Decimal? total { get; set; }


    }
}

using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class NumeroCorrelativo : BaseEntity
    {
        [Key]
        public int IdNumeroDocumento { get; set; }
        public int UltimoNumero { get; set; }
        public int? CantidadDigitos { get; set; }
        public String? Gestion { get; set; }
        public DateTime? FechaActualizacion { get; set; }


    }
}

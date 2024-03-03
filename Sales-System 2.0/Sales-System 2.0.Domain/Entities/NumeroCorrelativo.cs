using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class NumeroCorrelativo : BaseEntity
    {
        [Key]
        public int idNumeroDocumento { get; set; }
        public int ultimoNumero { get; set; }
        public int? cantidadDigitos { get; set; }
        public String? gestion { get; set; }
        public DateTime? fechaActualizacion { get; set; }


    }
}

using Sales_System_2._0.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Sales_System_2._0.Domain.Entities
{
    public class Empleado : Person
    {
        [Key]
        public decimal sueldo { get; set; }
        public String? DepartamentoPertenece { get; set; }
        public String? Supervisor { get; set; }


    }
}

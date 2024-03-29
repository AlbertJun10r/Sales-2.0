using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System_2._0.Domain.Core
{
    public abstract class Person : BaseEntity
    {
        public DateTime? FechaRegistro { get; set; }
        public String? Correo { get; set; }
        public String? Clave { get; set; }


    }
}

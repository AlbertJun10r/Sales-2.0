using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System_2._0.Domain.Core
{
    public abstract class BaseEntity
    {
        public bool EsActivo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int IdUsuarioCreacion { get; set; }
        public DateTime? FechaMod { get; set; }
        public int? IdUsuarioMod { get; set; }
        public int? IdUsuarioElimino { get; set; }
        public DateTime? FechaElimino { get; set; }
        public bool Eliminado { get; set; }

    }
}

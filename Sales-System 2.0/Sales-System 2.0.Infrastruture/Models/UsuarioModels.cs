using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System_2._0.Infrastructure.Models
{
    public class UsuarioModel
    {
        public int idUsuario { get; set; }
        public string? nombre { get; set; }
        public string? correo { get; set; }
        public string? clave { get; set; }
        public int? idRol { get; set; }
        public DateTime? fechaRegistro { get; set; }
    }
}

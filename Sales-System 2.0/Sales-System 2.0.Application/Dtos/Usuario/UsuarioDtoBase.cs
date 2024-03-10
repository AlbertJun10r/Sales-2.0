

using Sales_System_2._0.Application.Dtos.Base;
using System;

namespace Sales_System_2._0.Application.Dtos.Usuario
{
    public class UsuarioDtoBase : DtoBase
    {
        public string? nombre { get; set; }
        public string? correo { get; set; }
        public string? clave { get; set; }
        public int? idRol { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public bool? esActivo { get; set; }
    }
}


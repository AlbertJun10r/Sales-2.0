

using Sales_System_2._0.Application.Dtos.Base;
using System;

namespace Sales_System_2._0.Application.Dtos.Usuario
{
    public class UsuarioDtoBase : DtoBase
    {
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public int? IdRol { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? EsActivo { get; set; }
    }
}


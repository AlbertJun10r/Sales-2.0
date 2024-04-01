using Sales_System_2._0.Api.Models.Modules.Core;

namespace Sales_System_2._0.Api.Models.Modules.Usuario
{
    public class UsuarioBaseModel : ModelBase
    {
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? EsActivo { get; set; }
    }
}

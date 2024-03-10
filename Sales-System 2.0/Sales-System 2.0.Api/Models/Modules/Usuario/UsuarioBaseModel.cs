using Sales_System_2._0.Api.Models.Modules.Core;

namespace Sales_System_2._0.Api.Models.Modules.Usuario
{
    public class UsuarioBaseModel : ModelBase
    {
        public string? nombre { get; set; }
        public string? correo { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public bool? esActivo { get; set; }
    }
}

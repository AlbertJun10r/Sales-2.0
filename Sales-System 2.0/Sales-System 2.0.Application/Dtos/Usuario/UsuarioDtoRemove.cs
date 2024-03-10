using Sales_System_2._0.Application.Dtos.Base;

namespace Sales_System_2._0.Application.Dtos.Usuario
{
    public class UsuarioDtoRemove : DtoBase
    {
        public string? nombre { get; set; }
        public int idUsuario { get; set; }
        public bool Eliminado { get; set; }
    }
}

namespace Sales_System_2._0.Api.Models.Modules.Usuario
{
    public class GetUsuarioModel
    {
        public int IdUsuarioCreacion { get; set; }
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}

namespace Sales_System_2._0.Api.Models.Modules.Usuario
{
    public class GetUsuarioModel
    {
        public int IdUsuarioCreacion { get; set; }
        public string? nombre { get; set; }
        public string? correo { get; set; }
        public string? clave { get; set; }
        public DateTime? fechaRegistro { get; set; }
    }
}

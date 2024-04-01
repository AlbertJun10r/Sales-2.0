namespace Sales_System_2._0.Web.Models.Responses
{
    public class UsuarioViewResult
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}

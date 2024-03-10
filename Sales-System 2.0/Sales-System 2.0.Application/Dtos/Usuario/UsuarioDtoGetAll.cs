using System;


namespace Sales_System_2._0.Application.Dtos.Usuario
{
    public class UsuarioDtoGetAll
    {
        public int idUsuario { get; set; }
        public string? nombre { get; set; }
        public string? correo {  get; set; }
        public int? idRol { get; set; }
        public DateTime? fechaRegistro { get; set; }
        public bool? esActivo { get; set; }

    }

}

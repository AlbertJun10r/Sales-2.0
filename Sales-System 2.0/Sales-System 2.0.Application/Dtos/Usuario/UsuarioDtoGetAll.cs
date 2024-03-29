using System;


namespace Sales_System_2._0.Application.Dtos.Usuario
{
    public class UsuarioDtoGetAll
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Correo {  get; set; }
        public int? IdRol { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? EsActivo { get; set; }

    }

}

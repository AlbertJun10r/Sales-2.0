using Microsoft.Extensions.Configuration;
using Sales_System_2._0.Application.Core;
using Sales_System_2._0.Application.Dtos.Usuario;
using Sales_System_2._0.Application.Excepctions;


namespace Sales_System_2._0.Application.Extentions
{
    public static class ValidationUsuarioExtention
    {
        public static ServiceResult IsUsuarioValid(this UsuarioDtoBase dtoBase, IConfiguration configuration)
        {

            ServiceResult Result = new ServiceResult();

            if (string.IsNullOrEmpty(dtoBase.Nombre))
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioNombreRequerido"]);


            if (dtoBase.Nombre.Length > 50)
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioNombreLongitud"]);

            if (string.IsNullOrEmpty(dtoBase.Correo))
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioCorreoRequerido"]);

            if (dtoBase.Correo.Length > 50)
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioCorreoApellidoLongitud"]);

            if (!dtoBase.FechaRegistro.HasValue)
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioFechaRegistroRequerido"]);



            return Result;
        }
    }
}


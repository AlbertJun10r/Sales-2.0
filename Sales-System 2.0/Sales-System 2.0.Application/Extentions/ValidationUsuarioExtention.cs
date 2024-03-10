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

            if (string.IsNullOrEmpty(dtoBase.nombre))
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioNombreRequerido"]);


            if (dtoBase.nombre.Length > 50)
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioNombreLongitud"]);

            if (string.IsNullOrEmpty(dtoBase.correo))
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioCorreoRequerido"]);

            if (dtoBase.correo.Length > 50)
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioCorreoApellidoLongitud"]);

            if (!dtoBase.fechaRegistro.HasValue)
                throw new UsuarioServiceExcepcion(configuration["MensajeValidaciones:UsuarioFechaRegistroRequerido"]);



            return Result;
        }
    }
}


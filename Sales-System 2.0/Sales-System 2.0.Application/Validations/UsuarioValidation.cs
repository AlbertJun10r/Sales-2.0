using Microsoft.Extensions.Configuration;
using Sales_System_2._0.Application.Core;
using Sales_System_2._0.Application.Dtos.Usuario;



namespace Sales_System_2._0.Application.Validations
{
    public static class UsuarioValidation
    {
        public static ServiceResult ValidateIdUsuario(int id, IConfiguration configuration)
        {
            ServiceResult result = new ServiceResult();

            if (id <= 0)
            {
                result.Message = $"El id de usuario que busca es invalido. id: {id}";
                result.Success = false;
                return result;
            }

            return result;
        }

        public static ServiceResult ValidateUsuarioAdd(this UsuarioDtoAdd usuarioDtoAdd)
        {
            ServiceResult result = new ServiceResult();

            if (usuarioDtoAdd.IdUsuarioMod <= 0)
            {
                result.Message = "Id del Usuario ejecutador es Invalido";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(usuarioDtoAdd.Nombre))
            {
                result.Message = "El nombre completo es requerido.";
                result.Success = false;
                return result;
            }

            if (usuarioDtoAdd.Nombre.Length > 50)
            {
                result.Message = "El nombre completo no puede exceder los 50 caracteres.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(usuarioDtoAdd.Clave))
            {
                result.Message = "La clave es requerida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(usuarioDtoAdd.Correo))
            {
                result.Message = "El correo es requerido.";
                result.Success = false;
                return result;
            }            

            return result;
        }

        public static ServiceResult ValidateUsuarioUpdate(this UsuarioDtoUpdate usuarioDtoUpdate)
        {
            ServiceResult result = new ServiceResult();

            if (usuarioDtoUpdate.Id <= 0)
            {
                result.Message = "Debe seleccionar un id usuario válido.";
                result.Success = false;
                return result;
            }

            if (usuarioDtoUpdate.IdUsuarioMod <= 0)
            {
                result.Message = "Id del Usuario ejecutador es Invalido";
                result.Success = false;
                return result;
            }

            if (usuarioDtoUpdate.Nombre?.Length > 50)
            {
                result.Message = "El nombre completo no puede exceder los 50 caracteres.";
                result.Success = false;
                return result;
            }

            return result;
        }

        public static ServiceResult ValidateUsuarioRemove(this UsuarioDtoRemove usuarioDtoRemove)
        {
            ServiceResult result = new ServiceResult();

            if (usuarioDtoRemove.IdUsuarioMod <= 0)
            {
                result.Message = "Id del Usuario ejecutador es Invalido";
                result.Success = false;
                return result;
            }

            if (usuarioDtoRemove.Id <= 0)
            {
                result.Message = "Debe seleccionar un id usuario válido.";
                result.Success = false;
                return result;
            }
            return result;
        }
    }
}

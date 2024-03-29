using Sales_System_2._0.Domain.Entities;
using Sales_System_2._0.Infrastructure.Context;
using Sales_System_2._0.Infrastructure.Core;
using Sales_System_2._0.Infrastructure.Models;
using Sales_System_2._0.Infrastructure.Interfaces;

namespace Sales_System_2._0.Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly SalesContext context;

        public UsuarioRepository(SalesContext context) : base(context)
        {
            this.context = context;
        }

        public override List<Usuario> GetEntities()
        {
            return base.GetEntities().Where(usu => !usu.Eliminado).ToList();
        }

        public override void Save(Usuario entity)
        {
            base.Save(entity);
            this.context.SaveChanges();
        }

        public override void Update(Usuario entity)
        {
            Usuario usuario = this.GetEntity(entity.Id);

            usuario.Id = entity.Id;
            usuario.FechaMod = entity.FechaMod;
            usuario.IdUsuarioMod = entity.IdUsuarioMod;
            usuario.Nombre = entity.Nombre;
            usuario.Correo = entity.Correo;
            usuario.Clave = entity.Clave;
            usuario.IdRol = entity.IdRol;

            this.context.Usuario.Update(usuario);
            this.context.SaveChanges();

        }


        public override void Remove(Usuario entity)
        {
            Usuario usuario = this.GetEntity(entity.Id);

            usuario.Id = entity.Id;
            usuario.Eliminado = entity.Eliminado = true;
            usuario.IdUsuarioElimino = entity.IdUsuarioElimino;
            usuario.FechaElimino = entity.FechaElimino;

            this.context.Usuario.Update(usuario);
            this.context.SaveChanges();
        }

        public List<UsuarioModel> GetUsuarios()
        {
            var usuarios = this.context.Usuario
                             .Where(usu => !usu.Eliminado)
                             .OrderByDescending(usu => usu.FechaRegistro)
                             .Select(usu => new UsuarioModel
                             {
                                 FechaRegistro = usu.FechaRegistro,
                                 IdRol = usu.IdRol,
                                 Nombre = usu.Nombre,
                                 Correo = usu.Correo,
                                 Id = usu.Id,
                             })
                                .ToList();

            return usuarios;
        }

        public UsuarioModel GetUsuario(int IdUsuario)
        {
            var usuarios = this.GetUsuarios();
            return usuarios.Find(s => s.Id == IdUsuario);
        }
    }
}
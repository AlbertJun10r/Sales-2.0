using Sales_System_2._0.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System_2._0.Domain.Repository
{
    public interface IUsuarioRepository
    {
        void Save(Usuario usuario);
        void Update(Usuario usuario);
        void Remove(Usuario usuario);
        List<Usuario> GetUsuarios();
        Usuario GetUsuario(int id);
    }
}

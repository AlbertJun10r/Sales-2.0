using Sales_System_2._0.Domain.Entities;
using Sales_System_2._0.Domain.Repository;
using Sales_System_2._0.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System_2._0.Infrastructure.Interfaces
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        public List<UsuarioModel> GetUsuarios();
        public UsuarioModel GetUsuario(int id);
    }
}

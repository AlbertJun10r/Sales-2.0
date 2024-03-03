using Microsoft.EntityFrameworkCore;
using Sales_System_2._0.Domain.Entities;

namespace Sales_System_2._0.Infrastructure.Context
{
    public partial class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {

        }
    }

    public partial class SalesContext
    {
        #region DbSet
        public DbSet<Rol> rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        #endregion
    }
}

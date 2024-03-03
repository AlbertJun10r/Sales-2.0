using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sales_System_2._0.Domain.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        List<TEntity> GetEntities();
        TEntity GetEntity(int id);
        bool Exists(Expression<Func<TEntity, bool>> filter);
        List<TEntity> FindAll(Expression<Func<TEntity, bool>> filter);
    }
}

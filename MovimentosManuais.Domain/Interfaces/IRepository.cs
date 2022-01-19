using System;
using System.Linq;
using System.Linq.Expressions;

namespace MovimentosManuais.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Create(TEntity model);
        bool Update(TEntity model);
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, object> includes);
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where);

    }
}

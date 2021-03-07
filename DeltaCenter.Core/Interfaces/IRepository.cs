using SharedKernel;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DeltaCenter.Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        IQueryable<TEntity> AllIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
        IQueryable<TEntity> All { get; }
        TEntity Find(int id);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        // void SetDataChanged();
        TEntity Insert(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);
        void DeleteAll(Expression<Func<TEntity, bool>> predicate);
        TEntity Update(TEntity entity);
    }
}

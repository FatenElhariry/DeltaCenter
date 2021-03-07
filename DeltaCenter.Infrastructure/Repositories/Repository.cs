using DeltaCenter.Core.Interfaces;
using DeltaCenter.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DeltaCenter.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseModel
    {
        private readonly AppDbContext _dbContext;
        private readonly ICurrentUserProvider _currentUserProvider;
        public Repository(AppDbContext dbContext, ICurrentUserProvider currentUserProvider)
        {
            _dbContext = dbContext;
            _currentUserProvider = currentUserProvider;
        }

        public IQueryable<TEntity> All => _dbContext.Set<TEntity>();

        public IQueryable<TEntity> AllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();
            return includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public void Delete(int id)
        {
            Delete(Find(id));
        }

        public void Delete(TEntity entity)
        {
            entity.DeletedAt = DateTime.Now;
            entity.DeletedBy = _currentUserProvider.UserId;
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void DeleteAll(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Find(int id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbContext.Set<TEntity>().Where(predicate);
        }

        public TEntity Insert(TEntity entity)
        {
            entity.CreatedBy = _currentUserProvider.UserId;
            entity.CreatedAt = DateTime.Now;
            _dbContext.Set<TEntity>().Add(entity);
            return entity;
        }

        //public void SetDataChanged()
        //{
        //    throw new NotImplementedException();
        //}

        public TEntity Update(TEntity entity)
        {
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = _currentUserProvider.UserId;
            _dbContext.Set<TEntity>().Update(entity);
            return entity;
        }
    }
}

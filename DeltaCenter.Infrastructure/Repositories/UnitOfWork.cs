using DeltaCenter.Core.Interfaces;
using DeltaCenter.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace DeltaCenter.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified, TransactionScopeOption? scopeOption = null)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}

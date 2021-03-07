using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace DeltaCenter.Core.Interfaces
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        void Dispose(bool disposing);
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified, TransactionScopeOption? scopeOption = null);
        void Commit();
        void Rollback();
    }
}

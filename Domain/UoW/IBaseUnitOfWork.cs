using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UoW
{
    public interface IBaseUnitOfWork : IDisposable
    {
        void BeginTransaction();
        bool SaveTransactionChanges();
        bool CommitTransaction();
        void RollBackTransaction();
    }
}

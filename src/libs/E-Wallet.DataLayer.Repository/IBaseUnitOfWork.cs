using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace E_Wallet.DataLayer.Repository
{
    public interface IBaseUnitOfWork
    {
        DbContext Context { get; }
        IDbContextTransaction CurrentTransaction { get; }
        TRepository GetRepository<TRepository>();
        IDbContextTransaction BeginTransaction();
        void Save();
        void Commit();
        void Rollback();
    }
}

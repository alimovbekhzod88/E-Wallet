using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.DataLayer.Repository
{
    public interface IUnitOfWork : IBaseUnitOfWork
    {
        IUserRepository UserRepository { get; }
    }
}

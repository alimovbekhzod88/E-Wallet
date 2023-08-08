using Global.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.DataLayer.Repository
{
    public interface IUserWalletRepository : IBaseEntityRepository<int,UserWallet, CreateUserWalletDlDto, UpdateUserWalletDlDto>
    {
    }
}

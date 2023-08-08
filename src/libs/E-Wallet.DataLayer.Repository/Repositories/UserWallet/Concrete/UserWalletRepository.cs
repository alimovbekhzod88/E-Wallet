using GenericServices.PublicButHidden;
using GenericServices;
using Global.shared;
using Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace E_Wallet.DataLayer.Repository
{
    public class UserWalletRepository : BaseEntityRepository<int, UserWallet, CreateUserWalletDlDto, UpdateUserWalletDlDto>, IUserWalletRepository
    {
        public UserWalletRepository(ICrudServices crudServices) :
            base(crudServices)
        {

        }

        protected override void OnCreate(UserWallet entity, CreateUserWalletDlDto dto)
            => base.OnCreate(entity, dto);

        protected override void OnUpdate(UserWallet entity, UpdateUserWalletDlDto dto)
            => base.OnUpdate(entity, dto);
    }
}

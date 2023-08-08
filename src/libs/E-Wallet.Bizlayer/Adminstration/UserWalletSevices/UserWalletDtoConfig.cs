using AutoMapper;
using E_Wallet.Bizlayer.UserWalletSevices;
using E_Wallet.DataLayer.Repository;
using GenericServices.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.Adminstration.UserWalletSevices
{
    public class UserWalletDtoConfig : PerDtoConfig<UserWalletDto, UserWallet>
    {
        public override Action<IMappingExpression<UserWallet, UserWalletDto>> AlterReadMapping => 
            cfg => cfg
                .ForMember(dto => dto.StateName, ex => ex.MapFrom(ent => ent.State.FullName))
                .ForMember(dto => dto.UserName, ex => ex.MapFrom(ent => ent.User.FirstName + " " + ent.User.LastName + " " + ent.User.MiddleName));
    }
}

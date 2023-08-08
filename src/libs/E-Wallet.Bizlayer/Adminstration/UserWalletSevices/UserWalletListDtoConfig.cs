using AutoMapper;
using E_Wallet.DataLayer.Repository;
using GenericServices.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.UserWalletSevices
{
    public class UserWalletListDtoConfig : PerDtoConfig<UserWalletListDto, UserWallet>
    {
        public override Action<IMappingExpression<UserWallet, UserWalletListDto>> AlterReadMapping =>
            cfg => cfg
                .ForMember(dto => dto.StateName, ex => ex.MapFrom(ent => ent.State.FullName))
                .ForMember(dto => dto.UserName, ex => ex.MapFrom(ent => ent.User.FirstName + " " + ent.User.LastName + " " + ent.User.MiddleName));
    }
}

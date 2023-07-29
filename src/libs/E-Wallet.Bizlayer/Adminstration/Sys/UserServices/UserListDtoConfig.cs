using AutoMapper;
using E_Wallet.DataLayer.Repository;
using GenericServices.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.Adminstration
{
    public class UserListDtoConfig : PerDtoConfig<UserListDto, User>
    {
        public override Action<IMappingExpression<User, UserListDto>> AlterReadMapping => 
            cfg => cfg 
                .ForMember(x=>x.StateName, ex=>ex.MapFrom(ent=>ent.State.FullName))
                .ForMember(x => x.DocumentType, ex => ex.MapFrom(ent => ent.DocumentType.FullName));
    }
}

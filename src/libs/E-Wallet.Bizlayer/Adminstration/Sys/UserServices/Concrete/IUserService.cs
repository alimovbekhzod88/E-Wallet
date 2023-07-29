using E_Wallet.DataLayer.Repository;
using Global.shared;
using StatusGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.Adminstration
{
    public interface IUserService : IStatusGeneric
    {
        PagedResult<UserListDto> GetUserList(SortFilterPageOptions options);
        UserDto GetUser();
        UserDto GetUserById(int userId);
        HaveId<int> CreateUser(CreateUserDto dto);
        void UpdateUser(UpdateUserDlDto dto);
        void DeleteUser(int userId);
    }
}

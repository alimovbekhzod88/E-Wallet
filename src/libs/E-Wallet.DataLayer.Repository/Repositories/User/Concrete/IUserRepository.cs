using Global.shared;
using GenericServices;
using Microsoft.EntityFrameworkCore;

namespace E_Wallet.DataLayer.Repository
{
    public interface IUserRepository : 
    IBaseEntityRepository<int, User, CreateUserDlDto, UpdateUserDlDto>
    {
        User ByFirstName(string firstName);
    }
}
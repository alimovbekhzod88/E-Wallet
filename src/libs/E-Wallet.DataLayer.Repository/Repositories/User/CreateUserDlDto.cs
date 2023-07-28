using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.DataLayer.Repository
{
    public class CreateUserDlDto : UserDlDto<CreateUserDlDto>
    {
        public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }
    }
}

using E_Wallet.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.UserWalletSevices
{
    public class UserWalletDto : UpdateUserWalletDlDto
    {
        public string UserName { get; set; } = null!;
        public string StateName { get; set; } = null!;
    }
}

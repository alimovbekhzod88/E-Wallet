using E_Wallet.DataLayer.Repository;
using GenericServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.UserWalletSevices
{
    public class UserWalletListDto : ILinkToEntity<UserWallet>
    {
        public int Id { get; set; }
        public string UniqueCode { get; set; } = null!;
        public int UserId { get; set; }
        public decimal? Amount { get; set; }
        public int StateId { get; set; }

        public string UserName { get; set; } = null!;
        public string StateName { get; set; } = null!;
    }
}

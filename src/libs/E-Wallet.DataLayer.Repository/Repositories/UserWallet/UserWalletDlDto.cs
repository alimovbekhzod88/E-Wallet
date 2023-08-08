using Global.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.DataLayer.Repository
{
    public class UserWalletDlDto<TDto> : EntityDto<TDto,UserWallet>
         where TDto : UserWalletDlDto<TDto>
    {
        [LocalizedRequired]
        [LocalizedStringLength(50)]
        public string UniqueCode { get; set; } = null!;
        public int UserId { get; set; }
        public decimal? Amount { get; set; }
    }

    public class LocalizedStringLengthAttribute : StringLengthAttribute
    {
        public LocalizedStringLengthAttribute(int maximumLength)
            :base(maximumLength)
        {
            
        }
    }
}

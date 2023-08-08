using Global.shared;
using Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.DataLayer.Repository
{
    public static class UserWalletFilter
    {
        public static IQueryable<UserWallet> ByUniqueCode(this IQueryable<UserWallet> source, string uniqueCode, bool isIcludePassive = false)
        {
            if(uniqueCode.NullOrEmpty())
                throw new ArgumentException($"{nameof(uniqueCode)} cannot be null or empty string", nameof(uniqueCode));
            if (!isIcludePassive)
                source = source.IsActive();
            return source.Where(x => x.UniqueCode.ToLower() == uniqueCode.ToLower());
        }
    }
}

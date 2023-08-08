using E_Wallet.DataLayer.Repository;
using Global;
using Global.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.UserWalletSevices
{
    public static class UserWalletSelectList
    {
        public static SelectList<int> AsSelectList(this IQueryable<UserWallet> userWallet)
        {
            return new SelectList<int>(
                userWallet
                    .IsActive()
                    .Select(userWallet => new SelectListItem<int>
                    {
                        Value = userWallet.Id,
                        OrderCode = userWallet.UniqueCode,
                        Text = userWallet.User.FirstName + " " + userWallet.User.LastName + " " + userWallet.User.MiddleName,
                    }).OrderBy(a => a.OrderCode).ThenBy(x => x.Text));
        }
    }
}

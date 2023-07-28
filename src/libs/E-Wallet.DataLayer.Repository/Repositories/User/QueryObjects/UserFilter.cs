using Global;
using Global.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.DataLayer.Repository
{
    public static class UserFilter
    {
        public static IQueryable<User> ByEmail(this IQueryable<User> source,
                                          string email,
                                          bool isIncludePassive = true)
        {
            if (email.NullOrEmpty())
                throw new ArgumentException($"{nameof(email)} cannot be null or empty string", nameof(email));

            if (!isIncludePassive)
                source = source.IsActive();

            return source.Where(user => user.EmailAddress.ToLower() == email.ToLower());
        }
    }
}

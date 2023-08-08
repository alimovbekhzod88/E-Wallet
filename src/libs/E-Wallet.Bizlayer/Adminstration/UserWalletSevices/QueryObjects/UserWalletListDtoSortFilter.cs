using Global.shared;
using System.Linq.Dynamic.Core;

namespace E_Wallet.Bizlayer.UserWalletSevices
{
    public static class UserWalletListDtoSortFilter
    {
        public static IQueryable<UserWalletListDto> SortFilter(this IQueryable<UserWalletListDto> query, ISortFilterOptions options)
        {
            if(options.HasSearch())
                query = query.Where(x=>x.UniqueCode.Contains(options.Search, StringComparison.OrdinalIgnoreCase) || x.StateName.Contains(options.Search, StringComparison.OrdinalIgnoreCase));

            if (options.HasSort())
                query = query.OrderBy($"{options.SortBy} {options.OrderType}");
            else
                query = query.OrderByDescending(a => a.Id);
            
            return query;
        }
    }
}

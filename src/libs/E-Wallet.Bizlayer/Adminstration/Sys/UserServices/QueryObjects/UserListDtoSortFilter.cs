using Global.shared;


namespace E_Wallet.Bizlayer.Adminstration
{
    public static class UserListDtoSortFilter
    {
        public static IQueryable<UserListDto> SortFilter(this IQueryable<UserListDto> query,
                                                     ISortFilterOptions options)
        {
            if (options.HasSearch())
                query = query.Where(userListDto => userListDto.FirstName.Contains(options.Search, StringComparison.OrdinalIgnoreCase) ||
                                                   userListDto.LastName.Contains(options.Search, StringComparison.OrdinalIgnoreCase) ||
                                                   userListDto.EmailAddress.Contains(options.Search, StringComparison.OrdinalIgnoreCase) ||
                                                   userListDto.MiddleName.Contains(options.Search, StringComparison.OrdinalIgnoreCase));

           /* if (options.HasSort())
                query = query.OrderBy($"{options.SortBy} {options.OrderType}");
            else
                query = query.OrderByDescending(userListDto => userListDto.Id);*/

            return query;
        }
    }
}

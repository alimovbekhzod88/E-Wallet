using Global.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.Adminstration
{
    public static class UserSelectList
    {
        public static PagedSelectList<int> AsSelectList(this PagedResult<UserListDto> pagedResult)
        {
            return new PagedSelectList<int>(
                pagedResult,
                pagedResult
                    .Rows
                    .Select(userListDto => new SelectListItem<int>
                    {
                        Value = userListDto.Id,
                        Text = userListDto.FirstName
                    }));
        }
    }
}

using E_Wallet.DataLayer.Repository;
using Global.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.EnumServices
{
    public static class StateSelectList
    {
        public static SelectList<int> AsSelectList(this IQueryable<State> source)
        {
            return new SelectList<int>(source.Select(state =>
                    new SelectListItem<int>
                    {
                        Value = state.Id,
                        Text = state.FullName
                    }));
        }
    }
}

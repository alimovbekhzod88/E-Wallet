using E_Wallet.DataLayer.Repository;
using Global.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.EnumServices
{
    public static class DocumentTypeSelectList
    {
        public static SelectList<int> AsSelectList(this IQueryable<DocumentType> source)
        {
            return new SelectList<int>(source.Select(documentType
                => new SelectListItem<int>
                {
                    Value = documentType.Id,
                    Text = documentType.FullName
                }));
        }
    }
}

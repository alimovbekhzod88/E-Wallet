using E_Wallet.DataLayer.Repository;
using GenericServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.Adminstration
{
    public class UserDto : UpdateUserDlDto, ILinkToEntity<User>
    {
        public string DocumentType { get; set; }
        public string StateName { get; set; }
    }
}

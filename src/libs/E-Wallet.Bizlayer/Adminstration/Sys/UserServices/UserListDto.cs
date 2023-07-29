using E_Wallet.DataLayer.Repository;
using GenericServices;
using Global.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Wallet.Bizlayer.Adminstration
{
    public class UserListDto : ILinkToEntity<User>, IHaveIdProp<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public int DocumentTypeId { get; set; }
        public string DocSeriaNumber { get; set; } = null!;
        public string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }
        public string? EmailAddress { get; set; }
        public int StateId { get; set; }

        public string DocumentType { get; set; }
        public string StateName { get; set; } 
    }
}

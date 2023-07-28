using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Global.shared;
using Microsoft.EntityFrameworkCore;

namespace E_Wallet.DataLayer.Repository
{
    [Table("sys_user")]
    [Index("StateId", Name = "sys_user_index__state_id")]
    [Index("FirstName", Name = "sys_user_index_first_name", IsUnique = true)]
    public class User : IHaveStateId
    {
        public User()
        {
            UserWallets = new HashSet<UserWallet>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(250)]
        public string FirstName { get; set; } = null!;
        [Column("last_name")]
        [StringLength(250)]
        public string LastName { get; set; } = null!;
        [Column("middle_name")]
        [StringLength(259)]
        public string MiddleName { get; set; } = null!;
        [Column("document_type_id")]
        public int DocumentTypeId { get; set; }
        [Column("doc_seria_number")]
        [StringLength(50)]
        public string DocSeriaNumber { get; set; } = null!;
        [Column("password_hash")]
        [StringLength(250)]
        public string? PasswordHash { get; set; }
        [Column("password_salt")]
        [StringLength(250)]
        public string? PasswordSalt { get; set; }
        [Column("email_address")]
        [StringLength(50)]
        public string? EmailAddress { get; set; }
        [Column("state_id")]
        public int StateId { get; set; }
        [Column("created_at", TypeName = "timestamp without time zone")]
        public DateTime CreatedAt { get; set; }
        [Column("created_by")]
        public int? CreatedBy { get; set; }
        [Column("modified_at", TypeName = "timestamp without time zone")]
        public DateTime? ModifiedAt { get; set; }
        [Column("modified_by")]
        public int? ModifiedBy { get; set; }

        [ForeignKey(nameof(DocumentTypeId))]
        public virtual DocumentType DocumentType { get; set; } = null!;
        [ForeignKey(nameof(StateId))]
        public virtual State State { get; set; } = null!;
        public virtual ICollection<UserWallet> UserWallets { get; set; }
    }
}

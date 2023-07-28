using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Wallet.DataLayer.Repository
{
    [Table("enum_state")]
    public class State
    {
        public State()
        {
            DocumentTypes = new HashSet<DocumentType>();
            Users = new HashSet<User>();
            UserWallets = new HashSet<UserWallet>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("order_code")]
        [StringLength(5)]
        public string? OrderCode { get; set; }
        [Column("short_name")]
        [StringLength(250)]
        public string? ShortName { get; set; }
        [Column("full_name")]
        [StringLength(500)]
        public string? FullName { get; set; }
        [Column("created_at", TypeName = "timestamp without time zone")]
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<DocumentType> DocumentTypes { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<UserWallet> UserWallets { get; set; }
    }
}

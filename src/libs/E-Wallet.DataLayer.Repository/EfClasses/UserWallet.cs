using Global.shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Wallet.DataLayer.Repository
{
    [Table("user_wallet")]
    public partial class UserWallet : IHaveStateId, IHaveIdProp<int>
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("unique_code")]
        [StringLength(12)]
        public string UniqueCode { get; set; } = null!;
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("amount")]
        public decimal? Amount { get; set; }
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

        [ForeignKey(nameof(StateId))]
        public virtual State State { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;
    }
}

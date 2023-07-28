using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_Wallet.DataAccessLayer.EfClasses
{
    [Keyless]
    [Table("sys_user_wallet_turnovor")]
    public partial class SysUserWalletTurnovor
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("on_date")]
        public DateOnly OnDate { get; set; }
        [Column("is_debit")]
        public bool? IsDebit { get; set; }
        [Column("amount")]
        public decimal? Amount { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("wallet_id")]
        public int WalletId { get; set; }
        [Column("created_at", TypeName = "timestamp without time zone")]
        public DateTime CreatedAt { get; set; }
        [Column("created_by")]
        public int? CreatedBy { get; set; }
        [Column("modified_at", TypeName = "timestamp without time zone")]
        public DateTime? ModifiedAt { get; set; }
        [Column("modified_by")]
        public int? ModifiedBy { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;
        [ForeignKey(nameof(WalletId))]
        public virtual UserWallet Wallet { get; set; } = null!;
    }
}

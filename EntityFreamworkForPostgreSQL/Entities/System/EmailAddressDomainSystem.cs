using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFreamworkForPostgreSQL.Entities.System
{
    /// <summary>
    /// メールアドレスドメインシステムテーブル
    /// </summary>
    [Table ( "s_email_address_domain" )]
    public class EmailAddressDomainSystem : BaseEntityColumn
    {
        /// <summary>
        /// ドメインID
        /// </summary>
        [Key]
        [Required]
        [Column ( "id" )]
        public int Id { get; set; }

        /// <summary>
        /// ドメイン
        /// </summary>
        [Required]
        [Column ( "domain" )]
        [StringLength ( 128 )]
        public string Domain { get; set; } = string.Empty;

        /// <summary>
        /// 論理削除
        /// </summary>
        [Required]
        [Column ( "is_deleted" )]
        public bool IsDeleted { get; set; }
    }
}

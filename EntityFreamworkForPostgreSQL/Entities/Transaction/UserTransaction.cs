using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFreamworkForPostgreSQL.Entities.Transaction
{
    /// <summary>
    /// ユーザテーブル
    /// </summary>
    [Table ( "t_user" )]
    public class UserTransaction : BaseEntityColumn
    {
        /// <summary>
        /// ユーザID
        /// </summary>
        [Key]
        [Required]
        [Column ( "id" )]
        [DatabaseGenerated ( DatabaseGeneratedOption.None )]
        public long Id { get; set; }

        /// <summary>
        /// ユーザマスタID
        /// </summary>
        [Required]
        [Column ( "m_user_id" )]
        public int MUserId { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        [Required]
        [Column ( "last_name" )]
        [StringLength ( 128 )]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// 名
        /// </summary>
        [Required]
        [Column ( "first_name" )]
        [StringLength ( 128 )]
        public string FirstName = string.Empty;

        /// <summary>
        /// メールアドレス
        /// </summary>
        [Required]
        [Column ( "email_address" )]
        [StringLength ( 128 )]
        public string EMailAddress { get; set; } = string.Empty;

        /// <summary>
        /// メールアドレスドメインID
        /// </summary>
        [Required]
        [Column ( "s_email_address_domain_id" )]
        public int SEmailAddressDomainId { get; set; }
    }
}

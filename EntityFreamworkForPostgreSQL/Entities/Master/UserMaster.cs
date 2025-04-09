using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFreamworkForPostgreSQL.Entities.Master
{
    /// <summary>
    /// ユーザマスタ
    /// </summary>
    [Table ( "m_user" )]
    public class UserMaster : BaseEntityColumn
    {
        /// <summary>
        /// ユーザマスタID
        /// </summary>
        [Key]
        [Required]
        [Column ( "id" )]
        [DatabaseGenerated ( DatabaseGeneratedOption.None )]
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [Column ( "name" )]
        [StringLength ( 128 )]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 論理削除
        /// </summary>
        [Required]
        [Column ( "is_deleted" )]
        public bool IsDeleted { get; set; }
    }
}

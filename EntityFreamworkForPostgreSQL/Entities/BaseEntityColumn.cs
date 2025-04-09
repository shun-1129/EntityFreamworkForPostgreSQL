using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFreamworkForPostgreSQL.Entities
{
    /// <summary>
    /// 共通カラムモデルクラス
    /// </summary>
    public class BaseEntityColumn
    {
        /// <summary>
        /// 作成日時
        /// </summary>
        [Required]
        [Column ( "created_at" )]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 作成者
        /// </summary>
        [Column ( "create_user" )]
        [StringLength ( 128 )]
        public string? CreateUser { get; set; }

        /// <summary>
        /// 作成プログラム
        /// </summary>
        [Required]
        [Column ( "create_program" )]
        [StringLength ( 128 )]
        public string CreateProgram { get; set; } = string.Empty;

        /// <summary>
        /// 更新日時
        /// </summary>
        [Required]
        [Column ( "updated_at" )]
        public DateTime UpdateAt { get; set; }

        /// <summary>
        /// 更新者
        /// </summary>
        [Column ( "update_user" )]
        [StringLength ( 128 )]
        public string? UpdateUser { get; set; }

        /// <summary>
        /// 更新プログラム
        /// </summary>
        [Required]
        [Column ( "update_program" )]
        [StringLength ( 128 )]
        public string UpdateProgram { get; set; } = string.Empty;
    }
}

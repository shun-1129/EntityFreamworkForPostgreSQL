using EntityFreamworkForPostgreSQL.Entities.Master;
using EntityFreamworkForPostgreSQL.Entities.System;
using EntityFreamworkForPostgreSQL.Entities.Transaction;
using Microsoft.EntityFrameworkCore;

namespace EntityFreamworkForPostgreSQL
{
    /// <summary>
    /// AppDBコンテキスト
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// ユーザマスタ
        /// </summary>
        public DbSet<UserMaster> TserMasters { get; set; }
        /// <summary>
        /// メールアドレスドメインシステムテーブル
        /// </summary>
        public DbSet<EmailAddressDomainSystem> EmailAddressDomainSystems { get; set; }
        /// <summary>
        /// ユーザテーブル
        /// </summary>
        public DbSet<UserTransaction> userTransactions { get; set; }

        /// <summary>
        /// コンフィグレーション
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
        {
            // DB接続
            optionsBuilder.UseNpgsql ( "Host=localhost;Port=5433;Database=sample_db;Username=postgres;Password=postgres;" );
            // 時間設定
            AppContext.SetSwitch ( "Npgsql.EnableLegacyTimestampBehavior" , true );
        }

        /// <summary>
        /// モデル作成
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating ( ModelBuilder modelBuilder )
        {
            #region マスタ
            modelBuilder.Entity<UserMaster> ( entity =>
            {
                // テーブル論理名設定
                entity.ToTable ( x => x.HasComment ( "ユーザマスタ" ) );
                // 主キー設定
                entity.HasKey ( x => x.Id );
                // 論理削除されたレコードを取得しないようにする。
                entity.HasQueryFilter ( x => !x.IsDeleted );
                // コメント定義
                entity.Property ( x => x.Id ).HasComment ( "ユーザマスタID:【値例】1" );
                entity.Property ( x => x.Name ).HasComment ( "名称:【値例】管理者" );
                entity.Property ( x => x.CreatedAt ).HasComment ( "作成日時:【値例】2025/04/09 10:00:00" );
                entity.Property ( x => x.CreateUser ).HasComment ( "作成者:【値例】System" );
                entity.Property ( x => x.CreateProgram ).HasComment ( "作成プログラム:【値例】System" );
                entity.Property ( x => x.UpdateAt ).HasComment ( "更新日時:【値例】2025/04/09 10:00:00" );
                entity.Property ( x => x.UpdateUser ).HasComment ( "更新者:【値例】System" );
                entity.Property ( x => x.UpdateProgram ).HasComment ( "更新プログラム:【値例】System" );
                entity.Property ( x => x.IsDeleted ).HasComment ( "論理削除:【値例】false：未削除 , true：削除済み" ).HasDefaultValue ( false );
            } );
            #endregion

            #region システム
            modelBuilder.Entity<EmailAddressDomainSystem> ( entity =>
            {
                // テーブル論理名設定
                entity.ToTable ( x => x.HasComment ( "メールアドレスドメインシステムテーブル" ) );
                // 主キー設定
                entity.HasKey ( x => x.Id );
                // 論理削除されたレコードを取得しないようにする。
                entity.HasQueryFilter ( x => !x.IsDeleted );
                // コメント定義
                entity.Property ( x => x.Id ).HasComment ( "ドメインID:【値例】1" );
                entity.Property ( x => x.Domain ).HasComment ( "ドメイン:【値例】管理者" );
                entity.Property ( x => x.CreatedAt ).HasComment ( "作成日時:【値例】2025/04/09 10:00:00" );
                entity.Property ( x => x.CreateUser ).HasComment ( "作成者:【値例】System" );
                entity.Property ( x => x.CreateProgram ).HasComment ( "作成プログラム:【値例】System" );
                entity.Property ( x => x.UpdateAt ).HasComment ( "更新日時:【値例】2025/04/09 10:00:00" );
                entity.Property ( x => x.UpdateUser ).HasComment ( "更新者:【値例】System" );
                entity.Property ( x => x.UpdateProgram ).HasComment ( "更新プログラム:【値例】System" );
                entity.Property ( x => x.IsDeleted ).HasComment ( "論理削除:【値例】false：未削除 , true：削除済み" ).HasDefaultValue ( false );
            } );
            #endregion

            #region トランザクション
            // ユーザテーブル定義
            modelBuilder.Entity<UserTransaction> ( entity =>
            {
                // テーブル論理名設定
                entity.ToTable ( x => x.HasComment ( "ユーザテーブル" ) );
                // 主キー設定
                entity.HasKey ( x => x.Id );
                // IDの型をBigserial型で指定
                entity.Property ( x => x.Id ).HasColumnType ( "bigserial" );
                // コメント
                entity.Property ( x => x.Id ).HasComment ( "ユーザID:【値例】1" );
                entity.Property ( x => x.MUserId ).HasComment ( "ユーザマスタID:【値例】1" );
                entity.Property ( x => x.LastName ).HasComment ( "姓:【値例】伊藤" );
                entity.Property ( x => x.FirstName ).HasComment ( "名:【値例】太郎" );
                entity.Property ( x => x.EMailAddress ).HasComment ( "メールアドレス:【値例】abcdefg" );
                entity.Property ( x => x.SEmailAddressDomainId ).HasComment ( "メールアドレスドメインID:【値例】1" );
                entity.Property ( x => x.CreatedAt ).HasComment ( "作成日時:【値例】2025/04/09 10:00:00" );
                entity.Property ( x => x.CreateUser ).HasComment ( "作成者:【値例】System" );
                entity.Property ( x => x.CreateProgram ).HasComment ( "作成プログラム:【値例】System" );
                entity.Property ( x => x.UpdateAt ).HasComment ( "更新日時:【値例】2025/04/09 10:00:00" );
                entity.Property ( x => x.UpdateUser ).HasComment ( "更新者:【値例】System" );
                entity.Property ( x => x.UpdateProgram ).HasComment ( "更新プログラム:【値例】System" );
            } );
            #endregion
        }
    }
}

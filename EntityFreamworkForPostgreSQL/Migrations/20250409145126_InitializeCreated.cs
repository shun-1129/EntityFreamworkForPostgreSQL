using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityFreamworkForPostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class InitializeCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "m_user",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "ユーザマスタID:【値例】1"),
                    name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "名称:【値例】管理者"),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false, comment: "論理削除:【値例】false：未削除 , true：削除済み"),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, comment: "作成日時:【値例】2025/04/09 10:00:00"),
                    create_user = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true, comment: "作成者:【値例】System"),
                    create_program = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "作成プログラム:【値例】System"),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, comment: "更新日時:【値例】2025/04/09 10:00:00"),
                    update_user = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true, comment: "更新者:【値例】System"),
                    update_program = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "更新プログラム:【値例】System")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_m_user", x => x.id);
                },
                comment: "ユーザマスタ");

            migrationBuilder.CreateTable(
                name: "s_email_address_domain",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false, comment: "ドメインID:【値例】1")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    domain = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "ドメイン:【値例】管理者"),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false, comment: "論理削除:【値例】false：未削除 , true：削除済み"),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, comment: "作成日時:【値例】2025/04/09 10:00:00"),
                    create_user = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true, comment: "作成者:【値例】System"),
                    create_program = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "作成プログラム:【値例】System"),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, comment: "更新日時:【値例】2025/04/09 10:00:00"),
                    update_user = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true, comment: "更新者:【値例】System"),
                    update_program = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "更新プログラム:【値例】System")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_s_email_address_domain", x => x.id);
                },
                comment: "メールアドレスドメインシステムテーブル");

            migrationBuilder.CreateTable(
                name: "t_user",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigserial", nullable: false, comment: "ユーザID:【値例】1"),
                    m_user_id = table.Column<int>(type: "integer", nullable: false, comment: "ユーザマスタID:【値例】1"),
                    last_name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "姓:【値例】伊藤"),
                    email_address = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "メールアドレス:【値例】abcdefg"),
                    s_email_address_domain_id = table.Column<int>(type: "integer", nullable: false, comment: "メールアドレスドメインID:【値例】1"),
                    first_name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "名:【値例】太郎"),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, comment: "作成日時:【値例】2025/04/09 10:00:00"),
                    create_user = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true, comment: "作成者:【値例】System"),
                    create_program = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "作成プログラム:【値例】System"),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, comment: "更新日時:【値例】2025/04/09 10:00:00"),
                    update_user = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true, comment: "更新者:【値例】System"),
                    update_program = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false, comment: "更新プログラム:【値例】System")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t_user", x => x.id);
                },
                comment: "ユーザテーブル");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "m_user");

            migrationBuilder.DropTable(
                name: "s_email_address_domain");

            migrationBuilder.DropTable(
                name: "t_user");
        }
    }
}

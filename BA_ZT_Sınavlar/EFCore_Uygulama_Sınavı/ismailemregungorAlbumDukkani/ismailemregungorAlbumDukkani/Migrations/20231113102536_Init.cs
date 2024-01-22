using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ismailemregungorAlbumDukkani.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KULLANICILAR",
                columns: table => new
                {
                    KULLANICI_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    AD = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    SOYAD = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    KULLANICI_ADI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    SIFRE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KULLANICILAR", x => x.KULLANICI_ID);
                });

            migrationBuilder.CreateTable(
                name: "SANATCILAR",
                columns: table => new
                {
                    SANATCI_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    SANATCI_ADI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANATCILAR", x => x.SANATCI_ID);
                });

            migrationBuilder.CreateTable(
                name: "ALBUMLER",
                columns: table => new
                {
                    ALBUM_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ALBUM_ADI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    YAYIM_TARİHİ = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ALBUM_FİYATI = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    INDIRIM_ORANI = table.Column<double>(type: "BINARY_DOUBLE", nullable: true),
                    ALBUM_DURUMU = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    SanatciID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ALBUMLER", x => x.ALBUM_ID);
                    table.ForeignKey(
                        name: "FK_ALBUMLER_SANATCILAR_SanatciID",
                        column: x => x.SanatciID,
                        principalTable: "SANATCILAR",
                        principalColumn: "SANATCI_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KULLANICILAR",
                columns: new[] { "KULLANICI_ID", "AD", "KULLANICI_ADI", "SIFRE", "SOYAD" },
                values: new object[] { 1, "Admin123", "Admin123", "3B612C75A7B5048A435FB6EC81E52FF92D6D795A8B5A9C17070F6A63C97A53B2", "Admin123" });

            migrationBuilder.CreateIndex(
                name: "IX_ALBUMLER_SanatciID",
                table: "ALBUMLER",
                column: "SanatciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ALBUMLER");

            migrationBuilder.DropTable(
                name: "KULLANICILAR");

            migrationBuilder.DropTable(
                name: "SANATCILAR");
        }
    }
}

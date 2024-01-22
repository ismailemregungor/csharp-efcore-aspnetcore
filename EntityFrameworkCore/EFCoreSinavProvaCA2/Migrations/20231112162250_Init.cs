using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSinavProvaCA2.Migrations
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
                    Ad = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    KullaniciAdi = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
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
                    SanatciAdi = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false)
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
                    AlbumAdi = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    YayimTarihi = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Fiyat = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    AlbumDurumu = table.Column<int>(type: "NUMBER(10)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "SARKILAR",
                columns: table => new
                {
                    SARKI_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    SarkiAdi = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    AlbumId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SARKILAR", x => x.SARKI_ID);
                    table.ForeignKey(
                        name: "FK_SARKILAR_ALBUMLER_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "ALBUMLER",
                        principalColumn: "ALBUM_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KULLANICILAR",
                columns: new[] { "KULLANICI_ID", "Ad", "KullaniciAdi", "Sifre", "Soyad" },
                values: new object[] { 1, "Admin-1", "Admin-1", "c9a1a6dcb58e47d08f2e6ef0dea893242bf7073de60cb6e577b7fbe892213a93", "Admin-1" });

            migrationBuilder.CreateIndex(
                name: "IX_ALBUMLER_SanatciID",
                table: "ALBUMLER",
                column: "SanatciID");

            migrationBuilder.CreateIndex(
                name: "IX_SARKILAR_AlbumId",
                table: "SARKILAR",
                column: "AlbumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KULLANICILAR");

            migrationBuilder.DropTable(
                name: "SARKILAR");

            migrationBuilder.DropTable(
                name: "ALBUMLER");

            migrationBuilder.DropTable(
                name: "SANATCILAR");
        }
    }
}

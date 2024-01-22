using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSinavProvaCA1.Migrations
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
                    AD = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    SOYAD = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    KULLANICI_ADI = table.Column<string>(type: "NVARCHAR2(20)", maxLength: 20, nullable: false),
                    SIFRE = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KULLANICILAR", x => x.KULLANICI_ID);
                });

            migrationBuilder.CreateTable(
                name: "YAYINEVLERI",
                columns: table => new
                {
                    YAYINEVI_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    YAYINEVI_ADI = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    ADRES = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YAYINEVLERI", x => x.YAYINEVI_ID);
                });

            migrationBuilder.CreateTable(
                name: "KITAPLAR",
                columns: table => new
                {
                    KITAP_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    KITAP_ADI = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    STOK_ADEDI = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    FIYAT = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    KITAP_DURUMU = table.Column<int>(type: "NUMBER(10)", nullable: false, defaultValue: 1),
                    EKLEME_TARIHI = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    YayinEviID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KITAPLAR", x => x.KITAP_ID);
                    table.ForeignKey(
                        name: "FK_KITAPLAR_YAYINEVLERI_YayinEviID",
                        column: x => x.YayinEviID,
                        principalTable: "YAYINEVLERI",
                        principalColumn: "YAYINEVI_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KULLANICILAR",
                columns: new[] { "KULLANICI_ID", "AD", "KULLANICI_ADI", "SIFRE", "SOYAD" },
                values: new object[] { 1, "Emre", "admin", "admin", "Güngör" });

            migrationBuilder.CreateIndex(
                name: "IX_KITAPLAR_YayinEviID",
                table: "KITAPLAR",
                column: "YayinEviID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KITAPLAR");

            migrationBuilder.DropTable(
                name: "KULLANICILAR");

            migrationBuilder.DropTable(
                name: "YAYINEVLERI");
        }
    }
}

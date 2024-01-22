using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreSinavProvaWFA1.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMINLER",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    KullaniciAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Sifre = table.Column<string>(type: "NVARCHAR2(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADMINLER", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "YAYINEVLERI",
                columns: table => new
                {
                    YayinEviID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Adi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YAYINEVLERI", x => x.YayinEviID);
                });

            migrationBuilder.CreateTable(
                name: "KITAPLAR",
                columns: table => new
                {
                    KitapID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Adi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "DECIMAL(18, 2)", nullable: false),
                    Durum = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    YayinEviID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KITAPLAR", x => x.KitapID);
                    table.ForeignKey(
                        name: "FK_KITAPLAR_YAYINEVLERI_YayinEviID",
                        column: x => x.YayinEviID,
                        principalTable: "YAYINEVLERI",
                        principalColumn: "YayinEviID");
                });

            migrationBuilder.InsertData(
                table: "ADMINLER",
                columns: new[] { "AdminID", "KullaniciAdi", "Sifre" },
                values: new object[] { 1, "admin", "21232F297A57A5A743894A0E4A801FC3" });

            migrationBuilder.CreateIndex(
                name: "IX_KITAPLAR_YayinEviID",
                table: "KITAPLAR",
                column: "YayinEviID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMINLER");

            migrationBuilder.DropTable(
                name: "KITAPLAR");

            migrationBuilder.DropTable(
                name: "YAYINEVLERI");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreModelFirst4.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KATEGORILER",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    KategoriAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KATEGORILER", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "URUNLER",
                columns: table => new
                {
                    UrunID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UrunAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UrunFiyati = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    KategoriID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URUNLER", x => x.UrunID);
                    table.ForeignKey(
                        name: "FK_URUNLER_KATEGORILER_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "KATEGORILER",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_URUNLER_KategoriID",
                table: "URUNLER",
                column: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "URUNLER");

            migrationBuilder.DropTable(
                name: "KATEGORILER");
        }
    }
}

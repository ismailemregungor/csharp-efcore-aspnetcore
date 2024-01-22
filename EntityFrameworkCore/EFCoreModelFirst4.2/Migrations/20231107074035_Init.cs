using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreModelFirst4._2.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KATEGORILER",
                columns: table => new
                {
                    KATEGORI_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 4 INCREMENT BY 1"),
                    KATEGORI_ADI = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KATEGORILER", x => x.KATEGORI_ID);
                });

            migrationBuilder.CreateTable(
                name: "URUNLER",
                columns: table => new
                {
                    URUN_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    URUN_ADI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FIYAT = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    KATEGORI_ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URUNLER", x => x.URUN_ID);
                    table.ForeignKey(
                        name: "FK_URUNLER_KATEGORILER_KATEGORI_ID",
                        column: x => x.KATEGORI_ID,
                        principalTable: "KATEGORILER",
                        principalColumn: "KATEGORI_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "KATEGORILER",
                columns: new[] { "KATEGORI_ID", "KATEGORI_ADI" },
                values: new object[] { 1, "Kırtasiye" });

            migrationBuilder.InsertData(
                table: "KATEGORILER",
                columns: new[] { "KATEGORI_ID", "KATEGORI_ADI" },
                values: new object[] { 2, "Elektronik" });

            migrationBuilder.InsertData(
                table: "KATEGORILER",
                columns: new[] { "KATEGORI_ID", "KATEGORI_ADI" },
                values: new object[] { 3, "Tekstil" });

            migrationBuilder.CreateIndex(
                name: "IX_URUNLER_KATEGORI_ID",
                table: "URUNLER",
                column: "KATEGORI_ID");
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

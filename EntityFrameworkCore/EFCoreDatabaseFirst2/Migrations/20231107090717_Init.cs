using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDatabaseFirst2.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "URUN2");

            migrationBuilder.CreateTable(
                name: "KATEGORILER",
                schema: "URUN2",
                columns: table => new
                {
                    KATEGORI_ID = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    KATEGORI_ADI = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KATEGORILER", x => x.KATEGORI_ID);
                });

            migrationBuilder.CreateTable(
                name: "URUNLER",
                schema: "URUN2",
                columns: table => new
                {
                    URUN_ID = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    URUN_ADI = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FIYAT = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    KATEGORI_ID = table.Column<int>(type: "NUMBER(10)", precision: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URUNLER", x => x.URUN_ID);
                    table.ForeignKey(
                        name: "FK_URUNLER_KATEGORILER_KATEGORI_ID",
                        column: x => x.KATEGORI_ID,
                        principalSchema: "URUN2",
                        principalTable: "KATEGORILER",
                        principalColumn: "KATEGORI_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "URUN2",
                table: "KATEGORILER",
                columns: new[] { "KATEGORI_ID", "KATEGORI_ADI" },
                values: new object[,]
                {
                    { 11, "Oyuncak" },
                    { 12, "Kitap" },
                    { 13, "Hobi" },
                    { 14, "Bahce" }
                });

            migrationBuilder.InsertData(
                schema: "URUN2",
                table: "URUNLER",
                columns: new[] { "URUN_ID", "FIYAT", "KATEGORI_ID", "URUN_ADI" },
                values: new object[,]
                {
                    { 100, 750.0, 11, "Tren" },
                    { 101, 750.0, 11, "Ucak" },
                    { 102, 100.0, 12, "Empati" },
                    { 103, 100.0, 12, "Simyacı" },
                    { 104, 100.0, 12, "Da Vinci Sifresi" },
                    { 105, 300.0, 13, "Satranc Seti" },
                    { 106, 300.0, 13, "Monopoly" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_URUNLER_KATEGORI_ID",
                schema: "URUN2",
                table: "URUNLER",
                column: "KATEGORI_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "URUNLER",
                schema: "URUN2");

            migrationBuilder.DropTable(
                name: "KATEGORILER",
                schema: "URUN2");
        }
    }
}

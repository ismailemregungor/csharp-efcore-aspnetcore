using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreModelFirst3.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Egitmenler",
                columns: table => new
                {
                    EgitmenID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EgitmenAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitmenler", x => x.EgitmenID);
                });

            migrationBuilder.CreateTable(
                name: "Ogrenciler",
                columns: table => new
                {
                    OgrenciID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    OgrenciAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenciler", x => x.OgrenciID);
                });

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    DersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DersAdi = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    EgitmenID = table.Column<int>(type: "NUMBER(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.DersID);
                    table.ForeignKey(
                        name: "FK_Dersler_Egitmenler_EgitmenID",
                        column: x => x.EgitmenID,
                        principalTable: "Egitmenler",
                        principalColumn: "EgitmenID");
                });

            migrationBuilder.CreateTable(
                name: "EgitmenDersleri",
                columns: table => new
                {
                    EgitmenDersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EgitmenID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitmenDersleri", x => x.EgitmenDersID);
                    table.ForeignKey(
                        name: "FK_EgitmenDersleri_Dersler_DersID",
                        column: x => x.DersID,
                        principalTable: "Dersler",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EgitmenDersleri_Egitmenler_EgitmenID",
                        column: x => x.EgitmenID,
                        principalTable: "Egitmenler",
                        principalColumn: "EgitmenID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgrenciDersleri",
                columns: table => new
                {
                    OgrenciDersID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    OgrenciID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DersID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Not = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciDersleri", x => x.OgrenciDersID);
                    table.ForeignKey(
                        name: "FK_OgrenciDersleri_Dersler_DersID",
                        column: x => x.DersID,
                        principalTable: "Dersler",
                        principalColumn: "DersID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciDersleri_Ogrenciler_OgrenciID",
                        column: x => x.OgrenciID,
                        principalTable: "Ogrenciler",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dersler_EgitmenID",
                table: "Dersler",
                column: "EgitmenID");

            migrationBuilder.CreateIndex(
                name: "IX_EgitmenDersleri_DersID",
                table: "EgitmenDersleri",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_EgitmenDersleri_EgitmenID",
                table: "EgitmenDersleri",
                column: "EgitmenID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersleri_DersID",
                table: "OgrenciDersleri",
                column: "DersID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDersleri_OgrenciID",
                table: "OgrenciDersleri",
                column: "OgrenciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EgitmenDersleri");

            migrationBuilder.DropTable(
                name: "OgrenciDersleri");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Egitmenler");
        }
    }
}

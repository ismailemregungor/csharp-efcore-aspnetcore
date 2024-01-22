using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreInheritanceStrategy.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisiler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Ad = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Soyad = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisiler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MUSTERILER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Cari = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MUSTERILER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MUSTERILER_Kisiler_ID",
                        column: x => x.ID,
                        principalTable: "Kisiler",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PERSONELLER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Maas = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONELLER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PERSONELLER_Kisiler_ID",
                        column: x => x.ID,
                        principalTable: "Kisiler",
                        principalColumn: "ID");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MUSTERILER");

            migrationBuilder.DropTable(
                name: "PERSONELLER");

            migrationBuilder.DropTable(
                name: "Kisiler");
        }
    }
}

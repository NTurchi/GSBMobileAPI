using Microsoft.EntityFrameworkCore.Migrations;

namespace APIGSB.Migrations
{
    public partial class GsbDbMCDExciptient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicamentExciptien");

            migrationBuilder.CreateTable(
                name: "MedicamentExciptient",
                columns: table => new
                {
                    MedicamentId = table.Column<int>(nullable: false),
                    ExciptientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentExciptient", x => new { x.MedicamentId, x.ExciptientId });
                    table.ForeignKey(
                        name: "FK_MedicamentExciptient_Exciptien_ExciptientId",
                        column: x => x.ExciptientId,
                        principalTable: "Exciptien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentExciptient_Medicament_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentExciptient_ExciptientId",
                table: "MedicamentExciptient",
                column: "ExciptientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicamentExciptient");

            migrationBuilder.CreateTable(
                name: "MedicamentExciptien",
                columns: table => new
                {
                    MedicamentId = table.Column<int>(nullable: false),
                    ExciptienId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentExciptien", x => new { x.MedicamentId, x.ExciptienId });
                    table.ForeignKey(
                        name: "FK_MedicamentExciptien_Exciptien_ExciptienId",
                        column: x => x.ExciptienId,
                        principalTable: "Exciptien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentExciptien_Medicament_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentExciptien_ExciptienId",
                table: "MedicamentExciptien",
                column: "ExciptienId");
        }
    }
}

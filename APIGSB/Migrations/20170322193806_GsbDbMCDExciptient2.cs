using Microsoft.EntityFrameworkCore.Migrations;

namespace APIGSB.Migrations
{
    public partial class GsbDbMCDExciptient2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentExciptient_Exciptien_ExciptientId",
                table: "MedicamentExciptient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exciptien",
                table: "Exciptien");

            migrationBuilder.RenameTable(
                name: "Exciptien",
                newName: "Exciptient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exciptient",
                table: "Exciptient",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentExciptient_Exciptient_ExciptientId",
                table: "MedicamentExciptient",
                column: "ExciptientId",
                principalTable: "Exciptient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicamentExciptient_Exciptient_ExciptientId",
                table: "MedicamentExciptient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exciptient",
                table: "Exciptient");

            migrationBuilder.RenameTable(
                name: "Exciptient",
                newName: "Exciptien");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exciptien",
                table: "Exciptien",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicamentExciptient_Exciptien_ExciptientId",
                table: "MedicamentExciptient",
                column: "ExciptientId",
                principalTable: "Exciptien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

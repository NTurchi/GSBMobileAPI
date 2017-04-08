using Microsoft.EntityFrameworkCore.Migrations;

namespace APIGSB.Migrations
{
    public partial class EditMedecin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Medecin",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoraireVisite",
                table: "Medecin",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telephone",
                table: "Medecin",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Medecin");

            migrationBuilder.DropColumn(
                name: "HoraireVisite",
                table: "Medecin");

            migrationBuilder.DropColumn(
                name: "Telephone",
                table: "Medecin");
        }
    }
}

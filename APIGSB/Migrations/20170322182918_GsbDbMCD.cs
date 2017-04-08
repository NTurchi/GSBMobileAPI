using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIGSB.Migrations
{
    public partial class GsbDbMCD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicaments_Familles_FamilleId",
                table: "Medicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicaments",
                table: "Medicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Familles",
                table: "Familles");

            migrationBuilder.RenameTable(
                name: "Medicaments",
                newName: "Medicament");

            migrationBuilder.RenameTable(
                name: "Familles",
                newName: "Famille");

            migrationBuilder.RenameColumn(
                name: "imgUrl",
                table: "Medicament",
                newName: "ImgUrl");

            migrationBuilder.RenameColumn(
                name: "MedicamentId",
                table: "Medicament",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Medicaments_FamilleId",
                table: "Medicament",
                newName: "IX_Medicament_FamilleId");

            migrationBuilder.RenameColumn(
                name: "FamilleId",
                table: "Famille",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "FamilleId",
                table: "Medicament",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Administration",
                table: "Medicament",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Commande",
                table: "Medicament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Indications",
                table: "Medicament",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Principe",
                table: "Medicament",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Prix",
                table: "Medicament",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Quantite",
                table: "Medicament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Medicament",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Medicament",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TauxRemboursement",
                table: "Medicament",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicament",
                table: "Medicament",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Famille",
                table: "Famille",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Exciptien",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exciptien", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pathologie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pathologie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ville",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DepartementId = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ville", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "MedicamentPathologie",
                columns: table => new
                {
                    MedicamentId = table.Column<int>(nullable: false),
                    PathologieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentPathologie", x => new { x.MedicamentId, x.PathologieId });
                    table.ForeignKey(
                        name: "FK_MedicamentPathologie_Medicament_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentPathologie_Pathologie_PathologieId",
                        column: x => x.PathologieId,
                        principalTable: "Pathologie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medecin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodePostal = table.Column<int>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    VilleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medecin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medecin_Ville_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Ville",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medecin_VilleId",
                table: "Medecin",
                column: "VilleId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentExciptien_ExciptienId",
                table: "MedicamentExciptien",
                column: "ExciptienId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentPathologie_PathologieId",
                table: "MedicamentPathologie",
                column: "PathologieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicament_Famille_FamilleId",
                table: "Medicament",
                column: "FamilleId",
                principalTable: "Famille",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicament_Famille_FamilleId",
                table: "Medicament");

            migrationBuilder.DropTable(
                name: "Medecin");

            migrationBuilder.DropTable(
                name: "MedicamentExciptien");

            migrationBuilder.DropTable(
                name: "MedicamentPathologie");

            migrationBuilder.DropTable(
                name: "Ville");

            migrationBuilder.DropTable(
                name: "Exciptien");

            migrationBuilder.DropTable(
                name: "Pathologie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicament",
                table: "Medicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Famille",
                table: "Famille");

            migrationBuilder.DropColumn(
                name: "Administration",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "Commande",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "Indications",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "Principe",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "Prix",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "Quantite",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Medicament");

            migrationBuilder.DropColumn(
                name: "TauxRemboursement",
                table: "Medicament");

            migrationBuilder.RenameTable(
                name: "Medicament",
                newName: "Medicaments");

            migrationBuilder.RenameTable(
                name: "Famille",
                newName: "Familles");

            migrationBuilder.RenameColumn(
                name: "ImgUrl",
                table: "Medicaments",
                newName: "imgUrl");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Medicaments",
                newName: "MedicamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Medicament_FamilleId",
                table: "Medicaments",
                newName: "IX_Medicaments_FamilleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Familles",
                newName: "FamilleId");

            migrationBuilder.AlterColumn<int>(
                name: "FamilleId",
                table: "Medicaments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicaments",
                table: "Medicaments",
                column: "MedicamentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Familles",
                table: "Familles",
                column: "FamilleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicaments_Familles_FamilleId",
                table: "Medicaments",
                column: "FamilleId",
                principalTable: "Familles",
                principalColumn: "FamilleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

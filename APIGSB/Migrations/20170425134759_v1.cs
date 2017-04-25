using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIGSB.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Excipient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Libelle = table.Column<string>(maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excipient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Famille",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Famille", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pathologie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Libelle = table.Column<string>(maxLength: 450, nullable: true)
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
                name: "Visiteur",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Matricule = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visiteur", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicament",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Administration = table.Column<string>(nullable: true),
                    Commande = table.Column<int>(nullable: false),
                    FamilleId = table.Column<int>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Indications = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(nullable: true),
                    Principe = table.Column<string>(nullable: true),
                    Prix = table.Column<decimal>(nullable: false),
                    Quantite = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Stock = table.Column<int>(nullable: false),
                    TauxRemboursement = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicament", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicament_Famille_FamilleId",
                        column: x => x.FamilleId,
                        principalTable: "Famille",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Medecin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adresse = table.Column<string>(nullable: true),
                    CodePostal = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HoraireVisite = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    VilleId = table.Column<int>(nullable: true),
                    VisiteurId = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Medecin_Visiteur_VisiteurId",
                        column: x => x.VisiteurId,
                        principalTable: "Visiteur",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicamentExcipient",
                columns: table => new
                {
                    MedicamentId = table.Column<int>(nullable: false),
                    ExcipientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentExcipient", x => new { x.MedicamentId, x.ExcipientId });
                    table.ForeignKey(
                        name: "FK_MedicamentExcipient_Excipient_ExcipientId",
                        column: x => x.ExcipientId,
                        principalTable: "Excipient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentExcipient_Medicament_MedicamentId",
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

            migrationBuilder.CreateIndex(
                name: "IX_Excipient_Libelle",
                table: "Excipient",
                column: "Libelle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medecin_VilleId",
                table: "Medecin",
                column: "VilleId");

            migrationBuilder.CreateIndex(
                name: "IX_Medecin_VisiteurId",
                table: "Medecin",
                column: "VisiteurId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicament_FamilleId",
                table: "Medicament",
                column: "FamilleId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentExcipient_ExcipientId",
                table: "MedicamentExcipient",
                column: "ExcipientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentPathologie_PathologieId",
                table: "MedicamentPathologie",
                column: "PathologieId");

            migrationBuilder.CreateIndex(
                name: "IX_Pathologie_Libelle",
                table: "Pathologie",
                column: "Libelle",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medecin");

            migrationBuilder.DropTable(
                name: "MedicamentExcipient");

            migrationBuilder.DropTable(
                name: "MedicamentPathologie");

            migrationBuilder.DropTable(
                name: "Ville");

            migrationBuilder.DropTable(
                name: "Visiteur");

            migrationBuilder.DropTable(
                name: "Excipient");

            migrationBuilder.DropTable(
                name: "Medicament");

            migrationBuilder.DropTable(
                name: "Pathologie");

            migrationBuilder.DropTable(
                name: "Famille");
        }
    }
}

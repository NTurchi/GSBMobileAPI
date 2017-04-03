using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIGSB.Migrations
{
    public partial class AddVisiteur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adresse",
                table: "Medecin",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisiteurId",
                table: "Medecin",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Visiteur",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visiteur", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medecin_VisiteurId",
                table: "Medecin",
                column: "VisiteurId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medecin_Visiteur_VisiteurId",
                table: "Medecin",
                column: "VisiteurId",
                principalTable: "Visiteur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medecin_Visiteur_VisiteurId",
                table: "Medecin");

            migrationBuilder.DropTable(
                name: "Visiteur");

            migrationBuilder.DropIndex(
                name: "IX_Medecin_VisiteurId",
                table: "Medecin");

            migrationBuilder.DropColumn(
                name: "Adresse",
                table: "Medecin");

            migrationBuilder.DropColumn(
                name: "VisiteurId",
                table: "Medecin");
        }
    }
}

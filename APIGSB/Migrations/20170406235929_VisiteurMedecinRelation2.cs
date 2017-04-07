using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIGSB.Migrations
{
    public partial class VisiteurMedecinRelation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "visiteurId",
                table: "Medecin");

            migrationBuilder.AddForeignKey(
                name: "FK_Medecin_Visiteur_VisiteurId",
                table: "Medecin",
                column: "VisiteurId",
                principalTable: "Visiteur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medecin_Visiteur_VisiteurId",
                table: "Medecin");

            migrationBuilder.AddForeignKey(
                name: "visiteurId",
                table: "Medecin",
                column: "VisiteurId",
                principalTable: "Visiteur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

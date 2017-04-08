using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIGSB.Migrations
{
    public partial class updatevisiteurmedecinlink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medecin_Visiteur_VisiteurId",
                table: "Medecin");

            migrationBuilder.DropColumn(
                name: "VisiteurMatricule",
                table: "Medecin");

            migrationBuilder.AlterColumn<int>(
                name: "VisiteurId",
                table: "Medecin",
                nullable: true,
                oldClrType: typeof(int));

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

            migrationBuilder.AlterColumn<int>(
                name: "VisiteurId",
                table: "Medecin",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisiteurMatricule",
                table: "Medecin",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Medecin_Visiteur_VisiteurId",
                table: "Medecin",
                column: "VisiteurId",
                principalTable: "Visiteur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

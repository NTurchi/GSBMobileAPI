using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIGSB.Migrations
{
    public partial class AddMatriculeForVisiteur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VisiteurMatricule",
                table: "Medecin");

            migrationBuilder.AddColumn<string>(
                name: "Matricule",
                table: "Visiteur",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Matricule",
                table: "Visiteur");

            migrationBuilder.AddColumn<string>(
                name: "VisiteurMatricule",
                table: "Medecin",
                nullable: true);
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIGSB.Migrations
{
    public partial class AddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicaments_Familles_FamilleId",
                table: "Medicaments");

            migrationBuilder.DropIndex(
                name: "IX_Medicaments_FamilleId",
                table: "Medicaments");

            migrationBuilder.AddColumn<byte>(
                name: "FamilleRefId",
                table: "Medicaments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicaments_FamilleRefId",
                table: "Medicaments",
                column: "FamilleRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicaments_Familles_FamilleRefId",
                table: "Medicaments",
                column: "FamilleRefId",
                principalTable: "Familles",
                principalColumn: "FamilleId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicaments_Familles_FamilleRefId",
                table: "Medicaments");

            migrationBuilder.DropIndex(
                name: "IX_Medicaments_FamilleRefId",
                table: "Medicaments");

            migrationBuilder.DropColumn(
                name: "FamilleRefId",
                table: "Medicaments");

            migrationBuilder.CreateIndex(
                name: "IX_Medicaments_FamilleId",
                table: "Medicaments",
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

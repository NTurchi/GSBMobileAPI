using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIGSB.Migrations
{
    public partial class SecondModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FamilleRefId",
                table: "Medicaments");

            migrationBuilder.AlterColumn<int>(
                name: "FamilleId",
                table: "Medicaments",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<int>(
                name: "FamilleId",
                table: "Familles",
                nullable: false,
                oldClrType: typeof(byte))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "FamilleId",
                table: "Medicaments",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<byte>(
                name: "FamilleRefId",
                table: "Medicaments",
                nullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "FamilleId",
                table: "Familles",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}

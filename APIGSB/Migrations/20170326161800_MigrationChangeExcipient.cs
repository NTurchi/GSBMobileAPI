using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIGSB.Migrations
{
    public partial class MigrationChangeExcipient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicamentExciptient");

            migrationBuilder.DropTable(
                name: "Exciptient");

            migrationBuilder.CreateTable(
                name: "Excipient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excipient", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentExcipient_ExcipientId",
                table: "MedicamentExcipient",
                column: "ExcipientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicamentExcipient");

            migrationBuilder.DropTable(
                name: "Excipient");

            migrationBuilder.CreateTable(
                name: "Exciptient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exciptient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MedicamentExciptient",
                columns: table => new
                {
                    MedicamentId = table.Column<int>(nullable: false),
                    ExciptientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicamentExciptient", x => new { x.MedicamentId, x.ExciptientId });
                    table.ForeignKey(
                        name: "FK_MedicamentExciptient_Exciptient_ExciptientId",
                        column: x => x.ExciptientId,
                        principalTable: "Exciptient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicamentExciptient_Medicament_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "Medicament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicamentExciptient_ExciptientId",
                table: "MedicamentExciptient",
                column: "ExciptientId");
        }
    }
}

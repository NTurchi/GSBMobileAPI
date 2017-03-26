using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using APIGSB.Models;

namespace APIGSB.Migrations
{
    [DbContext(typeof(ApigsbDbContext))]
    [Migration("20170219134129_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIGSB.Models.Famille", b =>
                {
                    b.Property<byte>("FamilleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom");

                    b.HasKey("FamilleId");

                    b.ToTable("Familles");
                });

            modelBuilder.Entity("APIGSB.Models.Medicaments", b =>
                {
                    b.Property<int>("MedicamentId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("FamilleId");

                    b.Property<string>("Nom");

                    b.HasKey("MedicamentId");

                    b.HasIndex("FamilleId");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("APIGSB.Models.Medicaments", b =>
                {
                    b.HasOne("APIGSB.Models.Famille", "Famille")
                        .WithMany("Medicaments")
                        .HasForeignKey("FamilleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using APIGSB.Models;

namespace APIGSB.Migrations
{
    [DbContext(typeof(ApigsbDbContext))]
    [Migration("20170322182918_GsbDbMCD")]
    partial class GsbDbMCD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIGSB.Models.Exciptien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Libelle");

                    b.HasKey("Id");

                    b.ToTable("Exciptien");
                });

            modelBuilder.Entity("APIGSB.Models.Famille", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom");

                    b.HasKey("Id");

                    b.ToTable("Famille");
                });

            modelBuilder.Entity("APIGSB.Models.Medecin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodePostal");

                    b.Property<string>("ImgUrl");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Nom");

                    b.Property<string>("Prenom");

                    b.Property<int?>("VilleId");

                    b.HasKey("Id");

                    b.HasIndex("VilleId");

                    b.ToTable("Medecin");
                });

            modelBuilder.Entity("APIGSB.Models.Medicament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Administration");

                    b.Property<int>("Commande");

                    b.Property<int?>("FamilleId");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Indications");

                    b.Property<string>("Nom");

                    b.Property<string>("Principe");

                    b.Property<decimal>("Prix");

                    b.Property<int>("Quantite");

                    b.Property<string>("Status");

                    b.Property<int>("Stock");

                    b.Property<decimal>("TauxRemboursement");

                    b.HasKey("Id");

                    b.HasIndex("FamilleId");

                    b.ToTable("Medicament");
                });

            modelBuilder.Entity("APIGSB.Models.MedicamentExciptien", b =>
                {
                    b.Property<int>("MedicamentId");

                    b.Property<int>("ExciptienId");

                    b.HasKey("MedicamentId", "ExciptienId");

                    b.HasIndex("ExciptienId");

                    b.ToTable("MedicamentExciptien");
                });

            modelBuilder.Entity("APIGSB.Models.MedicamentPathologie", b =>
                {
                    b.Property<int>("MedicamentId");

                    b.Property<int>("PathologieId");

                    b.HasKey("MedicamentId", "PathologieId");

                    b.HasIndex("PathologieId");

                    b.ToTable("MedicamentPathologie");
                });

            modelBuilder.Entity("APIGSB.Models.Pathologie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Libelle");

                    b.HasKey("Id");

                    b.ToTable("Pathologie");
                });

            modelBuilder.Entity("APIGSB.Models.Ville", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartementId");

                    b.Property<string>("Nom");

                    b.HasKey("Id");

                    b.ToTable("Ville");
                });

            modelBuilder.Entity("APIGSB.Models.Medecin", b =>
                {
                    b.HasOne("APIGSB.Models.Ville", "Ville")
                        .WithMany("Medecins")
                        .HasForeignKey("VilleId");
                });

            modelBuilder.Entity("APIGSB.Models.Medicament", b =>
                {
                    b.HasOne("APIGSB.Models.Famille", "Famille")
                        .WithMany("Medicaments")
                        .HasForeignKey("FamilleId");
                });

            modelBuilder.Entity("APIGSB.Models.MedicamentExciptien", b =>
                {
                    b.HasOne("APIGSB.Models.Exciptien", "Exciptien")
                        .WithMany("MedicamentExciptiens")
                        .HasForeignKey("ExciptienId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("APIGSB.Models.Medicament", "Medicament")
                        .WithMany("MedicamentExciptiens")
                        .HasForeignKey("MedicamentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("APIGSB.Models.MedicamentPathologie", b =>
                {
                    b.HasOne("APIGSB.Models.Medicament", "Medicament")
                        .WithMany("MedicamentPathologies")
                        .HasForeignKey("MedicamentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("APIGSB.Models.Pathologie", "Pathologie")
                        .WithMany("MedicamentPathologies")
                        .HasForeignKey("PathologieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

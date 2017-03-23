using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace APIGSB.Models
{
	/// <summary>
	/// Définition du DBContext. C'est la future base de donnée de l'application
	/// </summary>
    public class ApigsbDbContext : DbContext
    {
		/// <summary>
		/// Initialise une nouvelle instance de base de donnée
		/// </summary>
		/// <param name="options">Options.</param>
        public ApigsbDbContext(DbContextOptions<ApigsbDbContext> options)
        : base(options)
        {
			
        }

		/// <summary>
		/// Initialisation de la table Famille
		/// </summary>
		/// <value>Famille</value>
        public DbSet<Famille> Famille { get; set; }

		/// <summary>
		/// Initialisation de la table Medicament
		/// </summary>
		/// <value>Medicament</value>
        public DbSet<Medicament> Medicament { get; set; }

		/// <summary>
		/// Initialisation de la table Exciptient
		/// </summary>
		/// <value>Exciptien</value>
		public DbSet<Exciptient> Exciptient { get; set; }

		/// <summary>
		/// Initialisation de la table Ville
		/// </summary>
		/// <value>Ville</value>
		public DbSet<Ville> Ville { get; set; }

		/// <summary>
		/// Initialisation de la table Medecin
		/// </summary>
		/// <value>Medecin</value>
		public DbSet<Medecin> Medecin { get; set; }

		/// <summary>
		/// Initialisation de la table Pathologie
		/// </summary>
		/// <value>Pathologie</value>
		public DbSet<Pathologie> Pathologie { get; set; }

		/// <summary>
		/// Configuration de la connexion à la base de données
		/// </summary>
		/// <param name="optionsBuilder">Option de construction de la base de données</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer(@"data source=(LocalDb)\MSSQLLocalDB;initial catalog=APIGSB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;");
            optionsBuilder.UseSqlServer(@"Server=tcp:gsbdatabaseserver.database.windows.net,1433;Initial Catalog=GSBMOBILEAPIDB;Persist Security Info=False;User ID=rnrsolutions;Password=Admin123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

		/// <summary>
		/// Définitions des relations entre certaines entités
		/// </summary>
		/// <param name="modelBuilder">Model de construction des relations</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			#region Medicament Pathologie Clefs Etrangères (Many To Many)

			// Définition de la clef primaire composé de l'entité
			modelBuilder.Entity<MedicamentPathologie>()
			            .HasKey(mc => new { mc.MedicamentId, mc.PathologieId });
			
			// Mise en place de la relation de clef étrangère avec l'entité Médicament
			modelBuilder.Entity<MedicamentPathologie>()
			            .HasOne(mc => mc.Medicament)
			            .WithMany(m => m.MedicamentPathologies)
			            .HasForeignKey(mc => mc.MedicamentId);
			
			// Mise en place de la relation de clef étrangère avec l'entité Pathologie
			modelBuilder.Entity<MedicamentPathologie>()
			            .HasOne(mc => mc.Pathologie)
			            .WithMany(p => p.MedicamentPathologies)
			            .HasForeignKey(mc => mc.PathologieId);
			
			#endregion

			#region Medicament Exciptien Clefs Etrangères (Many To Many)

			// Définition de la clef primaire composé de l'entité
			modelBuilder.Entity<MedicamentExciptient>()
						.HasKey(mc => new { mc.MedicamentId, mc.ExciptientId });

			// Mise en place de la relation de clef étrangère avec l'entité Médicament
			modelBuilder.Entity<MedicamentExciptient>()
						.HasOne(mc => mc.Medicament)
						.WithMany(m => m.MedicamentExciptients)
						.HasForeignKey(mc => mc.MedicamentId);

			// Mise en place de la relation de clef étrangère avec l'entité Exciptien
			modelBuilder.Entity<MedicamentExciptient>()
			            .HasOne(mc => mc.Exciptient)
						.WithMany(p => p.MedicamentExciptients)
						.HasForeignKey(mc => mc.ExciptientId);

			#endregion
		}
    }
}
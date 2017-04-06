using System;
using System.Collections.Generic;
using System.Linq;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIGSB.Models.Repository
{
	/// <summary>
	/// Repository de l'entité <see cref="MedicamentPathologie"/> implémentant l'interface
	/// <see cref="IMedicamentPathologieRepository"/>
	/// </summary>
	public class MedicamentPathologieRepository : IMedicamentPathologieRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="MedicamentPathologieRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public MedicamentPathologieRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IMedicamentPathologieRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentPathologieRepository"/></returns>
		public IEnumerable<MedicamentPathologie> GetAll(int idMedicament)
		{
			// TODO: FAIRE PAR RAPPORT A L'ID DU MEDICAMENT
			var a = _context.MedicamentPathologie.ToList();
			return a;
		}

		/// <summary>
		/// Voir <see cref="IMedicamentPathologieRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentPathologieRepository"/></returns>
		public void Add(MedicamentPathologie medicamentPathologie)
		{
			_context.MedicamentPathologie.Add(medicamentPathologie);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentPathologieRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentPathologieRepository"/></returns>
		public void Remove(MedicamentPathologie medicamentPathologie)
		{
			MedicamentPathologie temp = _context.MedicamentPathologie.FirstOrDefault(mp => mp.MedicamentId == medicamentPathologie.MedicamentId && mp.PathologieId == medicamentPathologie.PathologieId);
			_context.MedicamentPathologie.Remove(temp);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentPathologieRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentPathologieRepository"/></returns>
		public void RemoveRangePathologie(int idMedicament, List<Pathologie> pathologies){
			Medicament medicament = _context.Medicament.Find(idMedicament);

			List<MedicamentPathologie> medicamentPathologies = new List<MedicamentPathologie>();

			foreach (Pathologie pathologie in pathologies)
			{
				medicamentPathologies.Add(new MedicamentPathologie()
				{
					MedicamentId = idMedicament,
					Medicament = medicament,
					Pathologie = pathologie,
					PathologieId = pathologie.Id
				});
			}

			_context.MedicamentPathologie.RemoveRange(medicamentPathologies);
		}
	}
}

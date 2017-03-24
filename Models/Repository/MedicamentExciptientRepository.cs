using System;
using System.Collections.Generic;
using System.Linq;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIGSB.Models.Repository
{
	/// <summary>
	/// Repository de l'entité <see cref="MedicamentExciptient"/> implémentant l'interface
	/// <see cref="IMedicamentExciptientRepository"/>
	/// </summary>
	public class MedicamentExciptientRepository : IMedicamentExciptientRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="MedicamentExciptientRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public MedicamentExciptientRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IMedicamentExciptientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentExciptientRepository"/></returns>
		public IEnumerable<MedicamentExciptient> GetAll(int idMedicament)
		{
			// TODO: FAIRE PAR RAPPORT A L'ID DU MEDICAMENT
			var a = _context.MedicamentExciptient.ToList();
			return a;
		}

		/// <summary>
		/// Voir <see cref="IMedicamentExciptientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentExciptientRepository"/></returns>
		public void Add(MedicamentExciptient medicamentExciptient)
		{
			_context.MedicamentExciptient.Add(medicamentExciptient);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentExciptientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentExciptientRepository"/></returns>
		public void Remove(MedicamentExciptient medicamentExciptient)
		{
			_context.MedicamentExciptient.Remove(medicamentExciptient);
			_context.SaveChanges();
		}
	}
}

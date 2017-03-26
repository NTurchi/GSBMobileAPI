using System;
using System.Collections.Generic;
using System.Linq;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIGSB.Models.Repository
{
	/// <summary>
	/// Repository de l'entité <see cref="MedicamentExcipient"/> implémentant l'interface
	/// <see cref="IMedicamentExcipientRepository"/>
	/// </summary>
	public class MedicamentExcipientRepository : IMedicamentExcipientRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="MedicamentExcipientRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public MedicamentExcipientRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IMedicamentExcipientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentExcipientRepository"/></returns>
		public IEnumerable<MedicamentExcipient> GetAll(int idMedicament)
		{
			// TODO: FAIRE PAR RAPPORT A L'ID DU MEDICAMENT
			var a = _context.MedicamentExcipient.ToList();
			return a;
		}

		/// <summary>
		/// Voir <see cref="IMedicamentExcipientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentExcipientRepository"/></returns>
		public void Add(MedicamentExcipient medicamentExcipient)
		{
			_context.MedicamentExcipient.Add(medicamentExcipient);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentExcipientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentExcipientRepository"/></returns>
		public void Remove(MedicamentExcipient medicamentExcipient)
		{
			_context.MedicamentExcipient.Remove(medicamentExcipient);
			_context.SaveChanges();
		}
	}
}

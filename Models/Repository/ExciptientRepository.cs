using System;
using System.Collections.Generic;
using System.Linq;
using APIGSB.Models.IRepository;

namespace APIGSB.Models.Repository
{
	/// <summary>
	/// Repository de l'entité <see cref="Exciptient"/> implémentant l'interface
	/// <see cref="IExciptientRepository"/>
	/// </summary>
	public class ExciptientRepository : IExciptientRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="ExciptientRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public ExciptientRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IExciptientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IExciptientRepository"/></returns>
		public IEnumerable<Exciptient> GetAll()
		{
			return _context.Exciptient.ToList();
		}
	}
}

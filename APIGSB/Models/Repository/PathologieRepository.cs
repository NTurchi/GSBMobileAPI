using System;
using APIGSB.Models.IRepository;
using APIGSB.Models;
using System.Collections.Generic;
using System.Linq;

namespace APIGSB
{
	/// <summary>
	/// Repository de l'entité <see cref="Pathologie"/> implémentant l'interface
	/// <see cref="IPathologieRepository"/>
	/// </summary>
	public class PathologieRepository : IPathologieRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="PathologieRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public PathologieRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IPathologieRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IPathologieRepository"/></returns>
		public IEnumerable<Pathologie> GetAll()
		{
			return _context.Pathologie.ToList();
		}
	}
}

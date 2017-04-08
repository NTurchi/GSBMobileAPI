using System.Collections.Generic;
using System.Linq;
using APIGSB.Models.IRepository;

namespace APIGSB.Models.Repository
{
	/// <summary>
	/// Repository de l'entité <see cref="Excipient"/> implémentant l'interface
	/// <see cref="IExcipientRepository"/>
	/// </summary>
	public class ExcipientRepository : IExcipientRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="ExcipientRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public ExcipientRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IExcipientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IExcipientRepository"/></returns>
		public IEnumerable<Excipient> GetAll()
		{
			return _context.Excipient.ToList();
		}
	}
}

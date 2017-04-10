using APIGSB.Models.IRepository;
using APIGSB.Models;
using System.Collections.Generic;
using System.Linq;
namespace APIGSB
{
	/// <summary>
	/// Repository de l'entité <see cref="Ville"/> implémentant l'interface
	/// <see cref="IVilleRepository"/>
	/// </summary>
	public class VilleRepository : IVilleRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="VilleRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public VilleRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IVilleRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IVilleRepository"/></returns>
		public IEnumerable<Ville> GetAll()
		{
			return _context.Ville.ToList();
		}

	        /// <summary>
	        /// Voir <see cref="IVilleRepository"/>
	        /// </summary>
	        /// <param name="matricule">Voir <see cref="IVilleRepository"/></param>
	        /// <returns></returns>
		public IEnumerable<Ville> MedecinsVillesUsingMatricule(string matricule)
		{
		return from medecin in _context.Medecin.Where(m => m.Visiteur.Matricule == matricule)
		   select medecin.Ville;
		}

		public IEnumerable<Ville> VillesUsingDepartement(int departementid)
		{
		return _context.Ville.Where(v => v.DepartementId == departementid);
		}

    }
}

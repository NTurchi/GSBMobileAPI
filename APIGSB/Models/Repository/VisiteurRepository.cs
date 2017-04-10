using System.Collections.Generic;
using System.Linq;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIGSB
{
	/// <summary>
	/// Repository de l'entité <see cref="Medicament"/> implémentant l'interface
	/// <see cref="IMedicamentRepository"/>
	/// </summary>
	public class VisiteurRepository : IVisiteurRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="VisiteurRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public VisiteurRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IVisiteurRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IVisiteurRepository"/></returns>
		public Visiteur Find(int id)
		{
			return _context.Visiteur.Include(v => v.Medecins).ThenInclude(m => m.Ville).AsNoTracking().FirstOrDefault(v => v.Id == id);
		}

		/// <summary>
		/// Voir <see cref="IVisiteurRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IVisiteurRepository"/></returns>
		public IEnumerable<Visiteur> FindByNameUsingKeyword(string keyword)
		{
			return _context
				.Visiteur
				.Include(v => v.Medecins)
				.Where(v => v.Nom.ToLower().Contains(keyword.ToLower()));
		}

		/// <summary>
		/// Voir <see cref="IVisiteurRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IVisiteurRepository"/></returns>
		public void Update(Visiteur visiteur)
		{
			for (int i = 0; i < visiteur.Medecins.Count(); i++)
			{
				int idMed = visiteur.Medecins.ToList()[i].Id;
				visiteur.Medecins.ToList()[i] = _context.Medecin.Include(m => m.Ville).AsNoTracking().Single(m => m.Id == idMed);
			}

			_context.Visiteur.Update(visiteur);
			_context.SaveChanges();
		}
	}
}

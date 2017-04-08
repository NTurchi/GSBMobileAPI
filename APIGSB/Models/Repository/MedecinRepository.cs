using System.Collections.Generic;
using System.Linq;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIGSB.Models.Repository
{
	/// <summary>
	/// Repository de l'entité <see cref="Medecin"/> implémentant l'interface
	/// <see cref="IMedecinRepository"/>
	/// </summary>
	public class MedecinRepository : IMedecinRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="MedecinRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public MedecinRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IMedecinRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedecinRepository"/></returns>
		public IEnumerable<Medecin> GetAll()
		{
			return _context.Medecin.ToList();
		}
        /// <summary>
        /// Voir <see cref="IMedecinRepository"/>
        /// </summary>
        /// <param name="matricule">Voir <see cref="IMedecinRepository"/></param>
        /// <returns>Liste de médecins</returns>
	    public IEnumerable<Medecin> FindUsingMatricule(string matricule)
	    {
            return  _context.Medecin
                .Where(m => m.Visiteur.Matricule.ToLower() == matricule.ToLower())
                .Select(m => new Medecin
                {
                    Nom = m.Nom,
                    Id = m.Id,
                    Prenom = m.Prenom
                })
                .ToList();
	    }
        /// <summary>
        /// Voir <see cref="IMedecinRepository"/>
        /// </summary>
        /// <param name="villeid">Voir <see cref="IMedecinRepository"/></param>
        /// <param name="matricule">Voir <see cref="IMedecinRepository"/></param>
        /// <returns>Voir Interface</returns>
	    public IEnumerable<Medecin> GetAllUsingVilleAndMatricule(int villeid, string matricule)
        {
            var ville = _context.Ville.FirstOrDefault(v => v.Id == villeid);
            return _context.Medecin
                .Where(m => m.Ville == ville)
                .Where(m => m.Visiteur.Matricule == matricule);
	    }
        /// <summary>
        /// Voir <see cref="IMedecinRepository"/>
        /// </summary>
        /// <param name="villeid">Voir <see cref="IMedecinRepository"/></param>
        /// <returns>Voir Interface</returns>
	    public IEnumerable<Medecin> GetAllUsingVille(int villeid)
        {
            var ville = _context.Ville.FirstOrDefault(v => v.Id == villeid);
            return _context.Medecin
                .Where(m => m.Ville == ville);
        }
        /// <summary>
        /// Voir <see cref="IMedecinRepository"/>
        /// </summary>
        /// <returns>Voir <see cref="IMedecinRepository"/></returns>
        public void Add(Medecin medecin)
		{
			medecin.Ville = _context.Ville.Single(v => v.Id == medecin.Ville.Id);
			_context.Medecin.Add(medecin);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedecinRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedecinRepository"/></returns>
		public Medecin Find(int id)
		{
			return _context
                .Medecin
                .Include(m=>m.Ville)
				.Include(v=>v.Visiteur)
                .FirstOrDefault(t => t.Id == id);
		}
        /// <summary>
        /// voir <see cref="IMedecinRepository"/>
        /// </summary>
        /// <param name="keyword">Voir <see cref="IMedecinRepository"/></param>
        /// <returns></returns>
	    public IEnumerable<Medecin> FindByNameUsingKeyword(string keyword)
	    {
	        return _context
	            .Medecin
	            .Include(m => m.Ville)
	            .Where(m => m.Nom.ToLower().Contains(keyword.ToLower()));
	    }
        /// <summary>
        /// Voir <see cref="IMedecinRepository"/>
        /// </summary>
        /// <returns>Voir <see cref="IMedecinRepository"/></returns>
        public void Remove(int id)
		{
			var entity = _context.Medecin.First(t => t.Id == id);
			_context.Medecin.Remove(entity);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedecinRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedecinRepository"/></returns>
		public void Update(Medecin medecin)
		{
			medecin.Ville = _context.Ville.Single(v => v.Id == medecin.Ville.Id);
			_context.Medecin.Update(medecin);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedecinRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedecinRepository"/></returns>
		public Medecin GetByName(string nom, string prenom)
		{
			return _context.Medecin.FirstOrDefault(m => m.Nom == nom && m.Prenom == prenom);
		}
	}
}

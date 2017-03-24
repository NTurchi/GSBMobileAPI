using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIGSB.Models.Repository
{
	/// <summary>
	/// Repository de l'entité <see cref="Famille"/> implémentant l'interface
	/// <see cref="IFamilleRepository"/>
	/// </summary>
    public class FamilleRepository : IFamilleRepository
    {
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
        private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="FamilleRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
        public FamilleRepository(ApigsbDbContext context)
        {
            _context = context;
        }

		/// <summary>
		/// Voir <see cref="IFamilleRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IFamilleRepository"/></returns>
        public IEnumerable<Famille> GetAll()
        {
			var a = _context.Famille.Include(f=>f.Medicaments).AsNoTracking().ToList();
            return a;
        }

		/// <summary>
		/// Voir <see cref="IFamilleRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IFamilleRepository"/></returns>
        public void Add(Famille famille)
        {
            _context.Famille.Add(famille);
            _context.SaveChanges();
        }

		/// <summary>
		/// Voir <see cref="IFamilleRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IFamilleRepository"/></returns>
        public Famille Find(int id)
        {
            return _context.Famille.Include(f=>f.Medicaments).FirstOrDefault(t => t.Id == id);
        }

		/// <summary>
		/// Voir <see cref="IFamilleRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IFamilleRepository"/></returns>
        public void Remove(byte id)
        {
            var entity = _context.Famille.First(t => t.Id == id);
            _context.Famille.Remove(entity);
            _context.SaveChanges();
        }

		/// <summary>
		/// Voir <see cref="IFamilleRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IFamilleRepository"/></returns>
        public void Update(Famille famille)
        {
            _context.Famille .Update(famille);
            _context.SaveChanges();
        }
    }
}

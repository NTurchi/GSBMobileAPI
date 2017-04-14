using System.Collections.Generic;
using System.Linq;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIGSB.Models.Repository
{
	/// <summary>
	/// Repository de l'entité <see cref="Medicament"/> implémentant l'interface
	/// <see cref="IMedicamentRepository"/>
	/// </summary>
	public class MedicamentRepository : IMedicamentRepository
	{
		/// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
		private readonly ApigsbDbContext _context;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="MedicamentRepository"/>
		/// </summary>
		/// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
		public MedicamentRepository(ApigsbDbContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Voir <see cref="IMedicamentRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentRepository"/></returns>
		public IEnumerable<Medicament> GetAll()
		{
			return _context.Medicament
						       .Include(m => m.Famille).AsNoTracking()
				       .Include(m => m.MedicamentPathologies)
					       .ThenInclude(mp => mp.Pathologie)
				       .Include(m => m.MedicamentExcipients)
					       .ThenInclude(me => me.Excipient)
				       .ToList();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentRepository"/></returns>
		public IEnumerable<Medicament> GetAllNameAndFamilly()
		{
			return _context.Medicament
			    .Select(m => new Medicament
			    {
				    Nom = m.Nom,
				    Id = m.Id,
				    Famille = m.Famille
			    })
			    .ToList();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentRepository"/></returns>
		public void Add(Medicament medicament)
		{
			for (int i = 0; i < medicament.MedicamentExcipients.Count(); i++)
			{
				int eId = medicament.MedicamentExcipients.ToList()[i].ExcipientId;
				medicament.MedicamentExcipients.ToList()[i] = new MedicamentExcipient()
				{
					Medicament = medicament,
					Excipient = _context.Excipient.Single(e => e.Id == eId)
				};
			}

			for (int i = 0; i < medicament.MedicamentPathologies.Count(); i++)
			{
				int pId = medicament.MedicamentPathologies.ToList()[i].PathologieId;
				medicament.MedicamentPathologies.ToList()[i] = new MedicamentPathologie()
				{
					Medicament = medicament,
					Pathologie = _context.Pathologie.Single(p => p.Id == pId)
				};
			}

			medicament.Famille = _context.Famille.Single(f => f.Id == medicament.Famille.Id);
			_context.Medicament.Add(medicament);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentRepository"/></returns>
		public Medicament Find(int id)
		{
			return _context.Medicament.Include(m => m.Famille)
							       .Include(m => m.MedicamentPathologies)
								       .ThenInclude(mp => mp.Pathologie)
							       .Include(m => m.MedicamentExcipients)
								       .ThenInclude(me => me.Excipient)
						       .FirstOrDefault(t => t.Id == id);
		}

		/// <summary>
		/// Voir <see cref="IMedicamentRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentRepository"/></returns>
		public void Remove(int id)
		{
			var entity = _context.Medicament.First(t => t.Id == id);
			_context.Medicament.Remove(entity);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentRepository"/></returns>
		public void Update(Medicament medicament)
		{
			medicament.MedicamentExcipients = null;
			medicament.MedicamentPathologies = null;

			medicament.Famille = _context.Famille.Find(medicament.Famille.Id);
			_context.Medicament.Update(medicament);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentRepository"/></returns>
		public Medicament GetByName(string nom)
		{
			return _context.Medicament.FirstOrDefault(m => m.Nom == nom);
		}
	}
}

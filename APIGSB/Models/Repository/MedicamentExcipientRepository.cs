using System.Collections.Generic;
using System.Linq;
using APIGSB.Models.IRepository;

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
		public IEnumerable<Excipient> GetAll(int idMedicament)
		{
			var medicamentexciptients = _context.MedicamentExcipient.Where(me => me.MedicamentId == idMedicament).ToList();

			List<Excipient> excipients = new List<Excipient>();

			foreach(MedicamentExcipient me in medicamentexciptients)
			{
				excipients.Add(me.Excipient);
			}

			return excipients;
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
			MedicamentExcipient temp = _context.MedicamentExcipient.FirstOrDefault(me => me.ExcipientId == medicamentExcipient.ExcipientId && me.MedicamentId == medicamentExcipient.ExcipientId);
			_context.MedicamentExcipient.Remove(medicamentExcipient);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentExcipientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentExcipientRepository"/></returns>
		public void RemoveRangeExcipient(int idMedicament, List<Excipient> excipients){
			Medicament medicament = _context.Medicament.Find(idMedicament);

			List<MedicamentExcipient> medicamentExcipients = new List<MedicamentExcipient>();

			foreach(Excipient excipient in excipients)
			{
				medicamentExcipients.Add(new MedicamentExcipient()
				{
					MedicamentId = idMedicament,
					Medicament = medicament,
					Excipient = _context.Excipient.Find(excipient.Id),
					ExcipientId = excipient.Id
				});
			}
				
			_context.MedicamentExcipient.RemoveRange(medicamentExcipients);
			_context.SaveChanges();
		}

		/// <summary>
		/// Voir <see cref="IMedicamentExcipientRepository"/>
		/// </summary>
		/// <returns>Voir <see cref="IMedicamentExcipientRepository"/></returns>
		public void AddRangeExicipient(int idMedicament, List<Excipient> excipients)
		{
			Medicament medicament = _context.Medicament.Find(idMedicament);

			List<MedicamentExcipient> medicamentExcipients = new List<MedicamentExcipient>();

			foreach (Excipient excipient in excipients)
			{
				medicamentExcipients.Add(new MedicamentExcipient()
				{
					MedicamentId = idMedicament,
					Medicament = medicament,
					Excipient = _context.Excipient.Find(excipient.Id),
					ExcipientId = excipient.Id
				});
			}

			_context.MedicamentExcipient.AddRange(medicamentExcipients);
			_context.SaveChanges();
		}
	}
}

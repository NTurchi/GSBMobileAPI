using System;
using System.Collections.Generic;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB.Controllers
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Excipient"/>
	/// </summary>
	[Route("api/[controller]")]
	public class ExcipientController : Controller
	{
		/// <summary>
		/// Interface du repository des <see cref="Excipient"/> permettant l'injéction de dépendance
		/// </summary>
		/// <value>L'interface du repository des excipient</value>
		private IExcipientRepository _excipientRepository;

		/// <summary>
		/// Interface du repository des <see cref="MedicamentExcipient"/> permettant l'injéction de dépendance
		/// </summary>
		/// <value>L'inteface du repository des excipients d'un médicament</value>
		private IMedicamentExcipientRepository _medicamentExcipientRepository;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="ExcipientController"/>
		/// </summary>
		/// <param name="excipients">Le repository attaché à l'entité <see cref="Excipient"/></param>
		public ExcipientController(IExcipientRepository excipients, IMedicamentExcipientRepository medicamentExcipients)
		{
			_excipientRepository = excipients;
			_medicamentExcipientRepository = medicamentExcipients;
		}

		/// <summary>
		/// Envoie l'ensemble des <see cref="Excipient"/> de la base de données
		/// </summary>
		/// <returns>Les excipients de la base de données</returns>
		[HttpGet]
		public IEnumerable<Excipient> GetAll()
		{
			return _excipientRepository.GetAll();
		}

		/// <summary>
		/// Supprime un ensemble d'<see cref="Excipient"/> d'un <see cref="Medicament"/>
		/// </summary>
		/// <returns>Une page de resultat vide</returns>
		/// <param name="idMedicament">L'identifiant primaire du médicament</param>
		/// <param name="excipients">La collection d'excipient</param>
		[HttpPost("{idMedicament}", Name="DeleteExcipientsFromMedicament")]
		public IActionResult DeleteFromMedicament(int idMedicament, [FromBody] IEnumerable<Excipient> excipients)
		{
			_medicamentExcipientRepository.RemoveRangeExcipient(idMedicament, excipients as List<Excipient>);
			return new NoContentResult();
		}
	}
}

using Microsoft.AspNetCore.Mvc;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using System.Collections.Generic;

namespace APIGSB.Controllers
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="MedicamentExcipient">exciptients 
	/// d'un médicament</see>.
	/// </summary>
	[Route("api/[controller]")]
	public class MedicamentExcipientController : Controller
	{
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="MedicamentExcipient">exciptients 
		/// d'un médicament</see>
		/// </summary>
		/// <value>L'interface du repository permettant de gérer l'ajout et la suppression d'exciptient
		/// pour un médicament donné</value>
		public IMedicamentExcipientRepository _medicamentExcipientRepository { get; set; }

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="MedicamentExcipientController"/>
		/// </summary>
		/// <param name="repo">Le repository attaché à l'entité <see cref="MedicamentExcipient"/></param>
		public MedicamentExcipientController(IMedicamentExcipientRepository repo)
		{
			_medicamentExcipientRepository = repo;
		}

		/// <summary>
		/// Envoie l'ensemble des <see cref="Excipient"/> d'un <see cref="Medicament">médicament</see>
		/// </summary>
		/// <returns>Les exciptients d'un médicament</returns>
		[HttpGet("{id}", Name="GetMedicamentExcipient")]
		public IEnumerable<MedicamentExcipient> Get(int id)
		{
			return _medicamentExcipientRepository.GetAll(id);
		}

		/// <summary>
		/// Ajout un <see cref="Excipient"/> à un <see cref="Medicament" />
		/// </summary>
		/// <returns>Une réponse vide au client</returns>
		/// <param name="medicamentExciptient">L'objet MedicamentExciptient, faisant la liaision entre un médicament et
		///  un exciptient</param>
		[HttpPost]
		public IActionResult Create([FromBody] MedicamentExcipient medicamentExciptient)
		{
			_medicamentExcipientRepository.Add(medicamentExciptient);
			return new NoContentResult();
		}		

		/// <summary>
		/// Supprime un <see cref="Excipient"/> d'un <see cref="Medicament" />
		/// </summary>
		/// <returns>Une réponse vide au client</returns>
		/// <param name="medicamentExcipient">L'objet MedicamentExcipient, faisant la liaision entre un médicament et
		///  un excipient</param>
		[HttpDelete]
		public IActionResult Delete([FromBody] MedicamentExcipient medicamentExcipient)
		{
			_medicamentExcipientRepository.Remove(medicamentExcipient);
			return new NoContentResult();
		}
	}
}

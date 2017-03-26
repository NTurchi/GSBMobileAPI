using Microsoft.AspNetCore.Mvc;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using System.Collections.Generic;

namespace APIGSB
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="MedicamentPathologie">pathologies 
	/// d'un médicament</see>.
	/// </summary>
	[Route("api/[controller]")]
	public class MedicamentPathologieController
	{
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="MedicamentPathologie">pathologies 
		/// d'un médicament</see>
		/// </summary>
		/// <value>L'interface du repository permettant de gérer l'ajout et la suppression d'une pathologie
		/// pour un médicament donné</value>
		public IMedicamentPathologieRepository _medicamentPathologieRepository { get; set; }

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="MedicamentPathologieController"/>
		/// </summary>
		/// <param name="repo">Le repository attaché à l'entité <see cref="MedicamentPathologie"/></param>
		public MedicamentPathologieController(IMedicamentPathologieRepository repo)
		{
			_medicamentPathologieRepository = repo;
		}

		/// <summary>
		/// Envoie l'ensemble des <see cref="Pathologie"/> d'un <see cref="Medicament">médicament</see>
		/// </summary>
		/// <returns>Les pathologies d'un médicament</returns>
		[HttpGet("{id}", Name = "GetMedicamentPathologie")]
		public IEnumerable<MedicamentPathologie> Get(int id)
		{
			return _medicamentPathologieRepository.GetAll(id);
		}

		/// <summary>
		/// Ajoute une <see cref="Pathologie"/> à un <see cref="Medicament" />
		/// </summary>
		/// <returns>Une réponse vide au client</returns>
		/// <param name="medicamentPathologie">L'objet MedicamentPathologie, faisant la liaision entre un médicament et
		///  une pathologie</param>
		[HttpPost]
		public IActionResult Create([FromBody] MedicamentPathologie medicamentPathologie)
		{
			_medicamentPathologieRepository.Add(medicamentPathologie);
			return new NoContentResult();
		}

		/// <summary>
		/// Supprime une <see cref="Pathologie"/> d'un <see cref="Medicament" />
		/// </summary>
		/// <returns>Une réponse vide au client</returns>
		/// <param name="medicamentPathologie">L'objet MedicamentPathologie, faisant la liaision entre un médicament et
		///  une pathologie</param>
		[HttpDelete]
		public IActionResult Delete([FromBody] MedicamentPathologie medicamentPathologie)
		{
			_medicamentPathologieRepository.Remove(medicamentPathologie);
			return new NoContentResult();
		}
	}
}

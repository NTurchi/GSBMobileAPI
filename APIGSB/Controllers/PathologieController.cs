using System.Collections.Generic;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB.Controllers
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Pathologie"/>
	/// </summary>
	[Route("api/[controller]")]
	public class PathologieController : Controller
	{
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Pathologie"/>
		/// </summary>
		/// <value>L'interface du repository des pathologies</value>
		private IPathologieRepository _pathologieRepository;

		/// <summary>
		/// Interface du repository des <see cref="MedicamentPathologie"/> permettant l'injéction de dépendance
		/// </summary>
		/// <value>L'inteface du repository des pathologies d'un médicament</value>
		private IMedicamentPathologieRepository _medicamentPathologieRepository;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="PathologieController"/>
		/// </summary>
		/// <param name="pathologies">Le repository attaché à l'entité <see cref="Pathologie"/></param>
		public PathologieController(IPathologieRepository pathologies, IMedicamentPathologieRepository medicamentPathologies)
		{
			_pathologieRepository = pathologies;
			_medicamentPathologieRepository = medicamentPathologies;
		}

		/// <summary>
		/// Envoie l'ensemble des <see cref="Pathologie"/> de la base de données
		/// </summary>
		/// <returns>Les pathologies de la base de données</returns>
		[HttpGet]
		public IEnumerable<Pathologie> GetAll()
		{
			return _pathologieRepository.GetAll();
		}

		/// <summary>
		/// Supprime un ensemble de <see cref="Pathologie"/> d'un <see cref="Medicament"/>
		/// </summary>
		/// <returns>Une page de resultat vide</returns>
		/// <param name="idMedicament">L'identifiant primaire du médicament</param>
		/// <param name="pathologies">La collection de pathologie</param>
		[HttpDelete("{idMedicament}", Name = "DeletePathologiesFromMedicament")]
		public IActionResult DeleteFromMedicament(int idMedicament, [FromBody] IEnumerable<Pathologie> pathologies)
		{
			_medicamentPathologieRepository.RemoveRangePathologie(idMedicament, pathologies as List<Pathologie>);
			return new NoContentResult();
		}
	}
}

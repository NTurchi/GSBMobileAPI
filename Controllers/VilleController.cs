using System.Collections.Generic;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Medicament"/>
	/// </summary>
	[Route("api/[controller]")]
	public class VilleController : Microsoft.AspNetCore.Mvc.Controller
	{
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Ville"/>
		/// </summary>
		/// <value>L'interface du repository des villes</value>
		public IVilleRepository _villeRepository { get; set; }

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="VilleController"/>
		/// </summary>
		/// <param name="villes">Le repository attaché à l'entité <see cref="Ville"/></param>
		public VilleController(IVilleRepository villes)
		{
			_villeRepository = villes;
		}

		/// <summary>
		/// Envoie l'ensemble des <see cref="Ville"/> de la base de données
		/// </summary>
		/// <returns>Les familles de la base de données</returns>
		[HttpGet]
		public IEnumerable<Ville> GetAll()
		{
			return _villeRepository.GetAll();
		}
	}
}

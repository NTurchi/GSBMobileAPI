using System.Collections.Generic;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB.Controllers
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Ville"/>
	/// </summary>
	[Route("api/[controller]")]
	public class VilleController : Controller
	{
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Ville"/>
		/// </summary>
		/// <value>L'interface du repository des villes</value>
		private IVilleRepository _villeRepository;

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
		/// <returns>Les villes de la base de données</returns>
		[HttpGet]
		public IEnumerable<Ville> GetAll()
		{
			return _villeRepository.GetAll();
		}

        [HttpGet("{matricule}")]
        public IEnumerable<Ville> MedecinsVillesUsingMatricule(string matricule)
        {
            var a = _villeRepository.MedecinsVillesUsingMatricule(matricule);
            return _villeRepository.MedecinsVillesUsingMatricule(matricule);
        }

    }
}

using System.Collections.Generic;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Visiteur"/>
	/// </summary>
	[Route("api/[controller]")]
	public class VisiteurController : Controller
	{
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Visiteur"/>
		/// </summary>
		/// <value>L'interface du repository des visiteurs</value>
		private IVisiteurRepository _visiteurRepository;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="VisiteurController"/>
		/// </summary>
		/// <param name="visiteurs">Le repository attaché à l'entité <see cref="Visiteur"/></param>
		public VisiteurController(IVisiteurRepository visiteurs)
		{
			_visiteurRepository = visiteurs;
		}

		/// <summary>
		/// Modifie les propriétés d'un <see cref="Visiteur"/>
		/// </summary>
		/// <returns>Le resultat de la modification apportée</returns>
		/// <param name="id">l'identifiant primaire du visiteur à modifier</param>
		/// <param name="visiteur">Les nouvelles propriétés du visiteur</param>
		[HttpPut("{id}")]
		public IActionResult Update(int id, [FromBody] Visiteur visiteur)
		{
			if (visiteur == null || visiteur.Id != id)
			{
				return BadRequest();
			}

			Visiteur vi = _visiteurRepository.Find(id);
			if (vi == null)
			{
				return NotFound();
			}

			vi.Id = visiteur.Id;
			vi.Matricule = visiteur.Matricule;
			vi.Nom = visiteur.Nom;
			vi.Prenom = visiteur.Prenom;
			vi.Telephone = visiteur.Telephone;
			vi.Medecins = visiteur.Medecins;

			_visiteurRepository.Update(vi);
			return new NoContentResult();
		}

		/// <summary>
		/// Envoie des <see cref="Visiteur"/> de la base de données ayant le mot clé en partie dans leur nom de famille
		/// <param name="keyword">Mot clé de la recherche</param>
		/// </summary>
		/// <returns>Les visiteurs de la base de données correspondants à ces critères</returns>
		[HttpGet("keyword/{keyword}")]
		public IEnumerable<Visiteur> FindByNameUsingKeyword(string keyword)
		{
			return _visiteurRepository.FindByNameUsingKeyword(keyword);
		}
	}
}

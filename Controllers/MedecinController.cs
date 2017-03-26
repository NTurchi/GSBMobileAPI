using System.Collections.Generic;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using APIGSBAPIGSB.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB.Controllers
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Medecin"/>
	/// </summary>
	[Route("api/[controller]")]
	public class MedecinController : Controller
	{
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Medecin"/>
		/// </summary>
		/// <value>L'interface du repository des medecins</value>
		public IMedecinRepository _medecinRepository { get; set; }

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="MedecinController"/>
		/// </summary>
		/// <param name="medecins">Le repository attaché à l'entité <see cref="Medecin"/></param>
		public MedecinController(IMedecinRepository medecins)
		{
			_medecinRepository = medecins;
		}

		/// <summary>
		/// Envoie l'ensemble des <see cref="Medecin"/> de la base de données
		/// </summary>
		/// <returns>Les médecins de la base de données</returns>
		[HttpGet]
		public IEnumerable<Medecin> GetAll()
		{
			return _medecinRepository.GetAll();
		}

		/// <summary>
		/// Renvoie un <see cref="Medecin"/> bien précis à partir de son Id
		/// </summary>
		/// <returns>La médecin recherché</returns>
		/// <param name="id">L'identifiant primaire du médecin à trouver</param>
		[HttpGet("{id}", Name = "GetMedecin")]
		public IActionResult GetById(int id)
		{
			var item = _medecinRepository.Find(id);
			if (item == null)
			{
				return NotFound();
			}
			return new ObjectResult(item);
		}

		/// <summary>
		/// Créer un nouveau <see cref="Medecin" /> dans la base de données
		/// </summary>
		/// <returns>Le resultat de la création</returns>
		/// <param name="dtoMedecin">Le médecin à ajouter</param>
		[HttpPost]
		public IActionResult Create(DTOMedecin dtoMedecin)
		{
			if (dtoMedecin == null)
			{
				return BadRequest();
			}
			Medecin medecin = new Medecin()
			{
				Nom = dtoMedecin.Nom,
				Prenom = dtoMedecin.Prenom,
				CodePostal = dtoMedecin.CodePostal,
				ImgUrl = dtoMedecin.ImgUrl,
				Latitude = dtoMedecin.Latitude,
				Longitude = dtoMedecin.Longitude,
				Ville = dtoMedecin.Ville
				
			};

			_medecinRepository.Add(medecin);
			return new CreatedAtRouteResult("GetMedecin", new { id = _medecinRepository.GetByName(medecin.Nom, medecin.Prenom).Id });
		}

		/// <summary>
		/// Modifie les propriétés d'un <see cref="Medecin"/>
		/// </summary>
		/// <returns>Le resultat de la modification apportée</returns>
		/// <param name="id">l'identifiant primaire du médecin à modifier</param>
		/// <param name="medecin">Les nouvelles propriétés du médecin</param>
		[HttpPut("{id}")]
		public IActionResult Update(int id, [FromBody] Medecin medecin)
		{
			if (medecin == null || medecin.Id != id)
			{
				return BadRequest();
			}
			var med = _medecinRepository.Find(id);
			if (med == null)
			{
				return NotFound();
			}
			med.Nom = medecin.Nom;
			med.Id = medecin.Id;
			_medecinRepository.Update(med);
			return new NoContentResult();
		}

		/// <summary>
		/// Suprimmer le <see cref="Medecin"/> spécifié par son id
		/// </summary>
		/// <returns>Le resultat de l'action effecutée, ici une suppression</returns>
		/// <param name="id">L'identifiant primaire du médecin à supprimer</param>
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var Medecin = _medecinRepository.Find(id);
			if (Medecin == null)
			{
				return NotFound();
			}
			_medecinRepository.Remove(id);
			return new NoContentResult();
		}
	}
}

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
		private IMedecinRepository _medecinRepository;

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
		/// Renvoie des <see cref="Medecin"/> reliés au visiteur
		/// </summary>
		/// <returns>La médecin recherché</returns>
		/// <param name="matricule">Le matricule du visiteur référent</param>
		[HttpGet("matricule/{matricule}", Name = "GetMedecinsUsingMatricule")]
        public IEnumerable<Medecin> GetUsingMatricule(string matricule)
        {
            return _medecinRepository.FindUsingMatricule(matricule);
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
		public IActionResult Create([FromBody] DTOMedecin dtoMedecin)
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

			med.Id = medecin.Id;
			med.Nom = medecin.Nom;
			med.Prenom = medecin.Prenom;
			med.Telephone = medecin.Telephone;
			med.Email = medecin.Email;
			med.Adresse = medecin.Adresse;
			med.CodePostal = medecin.CodePostal;
			med.HoraireVisite = medecin.HoraireVisite;
			med.Latitude = medecin.Latitude;
			med.Longitude = medecin.Longitude;
			med.Ville = medecin.Ville;
			med.ImgUrl = medecin.ImgUrl;

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

        /// <summary>
		/// Envoie des <see cref="Medecin"/> de la base de données liés a ce matricule et situés dans cette ville
		/// <param name="villeid">Identifiant de la ville</param>
		/// <param name="matricule">Matricule du visiteur responsable</param>
		/// </summary>
		/// <returns>Les médecins de la base de données correspondants à ces critères</returns>
		[HttpGet("{villeid}/{matricule}")]
        public IEnumerable<Medecin> GetAllUsingVilleAndMatricule(int villeid, string matricule)
        {
            return _medecinRepository.GetAllUsingVilleAndMatricule(villeid, matricule);
        }

        /// <summary>
		/// Envoie des <see cref="Medecin"/> de la base de données ayant le mot clé en partie dans leur nom de famille
		/// <param name="keyword">Mot clé de la recherche</param>
		/// </summary>
		/// <returns>Les médecins de la base de données correspondants à ces critères</returns>
		[HttpGet("keyword/{keyword}")]
        public IEnumerable<Medecin> FindByNameUsingKeyword(string keyword)
        {
            return _medecinRepository.FindByNameUsingKeyword(keyword);
        }

        /// <summary>
		/// Envoie des <see cref="Medecin"/> de la base de données situés dans cette ville
		/// <param name="villeid">Identifiant de la ville</param>
		/// </summary>
		/// <returns>Les médecins de la base de données correspondants à ce critère</returns>
		[HttpGet("ville/{villeid}")]
        public IEnumerable<Medecin> GetAllUsingVille(int villeid)
        {
            return _medecinRepository.GetAllUsingVille(villeid);
        }
    }
}

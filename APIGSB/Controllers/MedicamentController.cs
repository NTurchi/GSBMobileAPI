using System.Collections.Generic;
using APIGSB.Models;
using APIGSB.Models.DTO;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB.Controllers
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Medicament"/>
	/// </summary>
	[Route("api/[controller]")]
	public class MedicamentController : Controller
	{
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Medicament"/>
		/// </summary>
		/// <value>L'interface du repository des médicaments</value>
		private IMedicamentRepository _medicamentRepository;

		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Excipient" /> d'un médicament
		/// </summary>
		private IMedicamentExcipientRepository _medicamentExcipientRepository;

		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Pathologie"/> d'un médicament
		/// </summary>
		private IMedicamentPathologieRepository _medicamentPathologieRepository;

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="MedicamentController"/>
		/// </summary>
		/// <param name="medicaments">Le repository attaché à l'entité <see cref="Medicament"/></param>
		public MedicamentController(IMedicamentRepository medicaments, IMedicamentExcipientRepository medicamentExcipient, IMedicamentPathologieRepository medicamentPathologie)
		{
			_medicamentRepository = medicaments;
			_medicamentExcipientRepository = medicamentExcipient;
			_medicamentPathologieRepository = medicamentPathologie;
		}

		/// <summary>
		/// Envoie l'ensemble des <see cref="Medicament"/> de la base de données
		/// </summary>
		/// <returns>Les médicaments de la base de données</returns>
		[HttpGet]
		public IEnumerable<Medicament> GetAll()
		{

			return _medicamentRepository.GetAll();
		}

		/// <summary>
		/// Envoie l'ensemble des infos de base des <see cref="Medicament"/> de la base de données
		/// </summary>
		/// <returns>Les médicaments de la base de données</returns>
		[HttpGet("short")]
		public IEnumerable<Medicament> GetAllNameAndFamilly()
		{
			return _medicamentRepository.GetAllNameAndFamilly();
		}

		/// <summary>
		/// Renvoie un <see cref="Medicament"/> bien précis à partir de son Id
		/// </summary>
		/// <returns>Le médicament recherché</returns>
		/// <param name="id">L'identifiant primaire du médicament à trouver</param>
		[HttpGet("{id}", Name = "GetMedicament")]
		public IActionResult GetById(int id)
		{
			var item = _medicamentRepository.Find(id);
			if (item == null)
			{
				return NotFound();
			}
			return new ObjectResult(item);
		}

		/// <summary>
		/// Créer un nouveau <see cref="Medicament" /> dans la base de données
		/// </summary>
		/// <returns>Le resultat de la création</returns>
		/// <param name="dtoMedicament">Le medicament à ajouter</param>
		[HttpPost]
		public IActionResult Create([FromBody] DTOMedicament dtoMedicament)
		{
			//List<MedicamentExcipient> excipients = new List<MedicamentExcipient>();
			//List<MedicamentPathologie> pathologies = new List<MedicamentPathologie>();
			if (dtoMedicament == null)
			{
				return BadRequest();
			}


			//foreach (MedicamentPathologie pathologie in dtoMedicament.MedicamentPathologies)
			//{
			//    pathologies.Add(pathologie);
			//}

			dtoMedicament.Famille.Medicaments = null;
			Medicament medicament = new Medicament()
			{
				Nom = dtoMedicament.Nom,
				Status = dtoMedicament.Status,
				Principe = dtoMedicament.Principe,
				Stock = dtoMedicament.Stock,
				Prix = dtoMedicament.Prix,
				Quantite = dtoMedicament.Quantite,
				TauxRemboursement = dtoMedicament.TauxRemboursement,
				Indications = dtoMedicament.Indications,
				Administration = dtoMedicament.Administration,
				ImgUrl = dtoMedicament.ImgUrl,
				Famille = dtoMedicament.Famille,
				MedicamentExcipients = dtoMedicament.MedicamentExcipients,
				MedicamentPathologies = dtoMedicament.MedicamentPathologies
			};

			_medicamentRepository.Add(medicament);

			return new CreatedAtRouteResult("GetMedicament", _medicamentRepository.GetByName(medicament.Nom));
		}

		/// <summary>
		/// Modifie les propriétés d'un <see cref="Medicament"/>
		/// </summary>
		/// <returns>Le resultat de la modification apportée</returns>
		/// <param name="id">l'identifiant primaire du médicament à modifier</param>
		/// <param name="medicament">Les nouvelles propriétés du médicament</param>
		[HttpPut("{id}")]
		public IActionResult Update(int id, [FromBody] Medicament medicament)
		{
			if (medicament == null || medicament.Id != id)
			{
				return BadRequest();
			}
			var med = _medicamentRepository.Find(id);

			if (med == null)
			{
				return NotFound();
			}

			med.Nom = medicament.Nom;
			med.Status = medicament.Status;
			med.Stock = medicament.Stock;
			med.Principe = medicament.Principe;
			med.Commande = medicament.Commande;
			med.Quantite = medicament.Quantite;
			med.Prix = medicament.Prix;
			med.TauxRemboursement = medicament.TauxRemboursement;
			med.Indications = medicament.Indications;
			med.Administration = medicament.Administration;
			med.ImgUrl = medicament.ImgUrl;
			med.Famille = medicament.Famille;
			med.MedicamentExcipients = medicament.MedicamentExcipients;
			med.MedicamentPathologies = medicament.MedicamentPathologies;

			_medicamentRepository.Update(med);
			return new NoContentResult();
		}

		/// <summary>
		/// Suprimmer le <see cref="Medicament"/> spécifié par son id
		/// </summary>
		/// <returns>Le resultat de l'action effecutée, ici une suppression</returns>
		/// <param name="id">L'identifiant primaire du médicament à supprimer</param>
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var medicament = _medicamentRepository.Find(id);
			if (medicament == null)
			{
				return NotFound();
			}
			_medicamentRepository.Remove(id);

			return new NoContentResult();
		}

		#region Ajout et suppression d'excipients

		/// <summary>
		/// Supprime une liste d'excipient d'un <see cref="Medicament"/> spécifié par son Id
		/// </summary>
		/// <returns>Http no content 204</returns>
		/// <param name="idMedicament">Identifiant du médicament</param>
		/// <param name="excipients">Les excipients</param>
		[HttpDelete("excipient/{idMedicament}")]
		public IActionResult DeleteExcipientRange(int idMedicament, [FromBody] List<Excipient> excipients)
		{
			_medicamentExcipientRepository.RemoveRangeExcipient(idMedicament, excipients);
			return new NoContentResult();
		}

		/// <summary>
		/// Ajoute des nouveaux excipients à un médicament
		/// </summary>
		/// <returns>Http no content 204</returns>
		/// <param name="idMedicament">L'identifiant primaire du médicament</param>
		/// <param name="excipients">Les exicipients</param>
		[HttpPost("excipient/{idMedicament}")]
		public IActionResult AddExcipientRange(int idMedicament, [FromBody] List<Excipient> excipients)
		{
			_medicamentExcipientRepository.AddRangeExicipient(idMedicament, excipients);
			return new NoContentResult();
		}

		#endregion

		/// <summary>
		/// Supprime une liste de pathologie d'un <see cref="Medicament"/> spécifié par son Id
		/// </summary>
		/// <returns>Http no content 204</returns>
		/// <param name="idMedicament">Identifiant du médicament</param>
		/// <param name="pathologies">Les pathologies</param>
		[HttpDelete("pathologie/{idMedicament}")]
		public IActionResult DeletePathologieRange(int idMedicament, [FromBody] List<Pathologie> pathologies)
		{
			_medicamentPathologieRepository.RemoveRangePathologie(idMedicament, pathologies);
			return new NoContentResult();
		}

		/// <summary>
		/// Ajoute des nouvelles pathologies à un médicament
		/// </summary>
		/// <returns>Http no content 204</returns>
		/// <param name="idMedicament">L'identifiant primaire du médicament</param>
		/// <param name="pathologies">Les pathologies</param>
		[HttpPost("pathologie/{idMedicament}")]
		public IActionResult AddPathologieRange(int idMedicament, [FromBody] List<Pathologie> pathologies)
		{
			_medicamentPathologieRepository.AddRangePathologie(idMedicament, pathologies);
			return new NoContentResult();
		}

	}
}

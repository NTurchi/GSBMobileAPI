﻿using System.Collections.Generic;
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
		/// Initialise une nouvelle instance de <see cref="MedicamentController"/>
		/// </summary>
		/// <param name="medicaments">Le repository attaché à l'entité <see cref="Medicament"/></param>
        public MedicamentController(IMedicamentRepository medicaments)
        {
            _medicamentRepository = medicaments;
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
		public IActionResult Create(DTOMedicament dtoMedicament)
		{
			if (dtoMedicament == null)
			{
				return BadRequest();
			}
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
				Famille = dtoMedicament.Famille
			};

			_medicamentRepository.Add(medicament);
			return new CreatedAtRouteResult("GetMedicament", new { id = _medicamentRepository.GetByName(medicament.Nom).Id });
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
            med.Id = medicament.Id;
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
    }
}
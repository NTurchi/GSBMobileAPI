using System.Collections.Generic;
using APIGSB.Models;
using Microsoft.AspNetCore.Mvc;
using APIGSB.Models.IRepository;
using APIGSB.Models.DTO;

namespace APIGSB.Controllers
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Famille"/>
	/// </summary>
    [Route("api/[controller]")]
    public class FamilleController : Microsoft.AspNetCore.Mvc.Controller
    {
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Famille"/>
		/// </summary>
		/// <value>L'interface du repository des familles</value>
        public IFamilleRepository _familleRepository { get; set; }

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="FamilleController"/>
		/// </summary>
		/// <param name="familles">Le repository attaché à l'entité <see cref="Famille"/></param>
        public FamilleController(IFamilleRepository familles)
        {
            _familleRepository = familles;
        }

		/// <summary>
		/// Envoie l'ensemble des <see cref="Famille"/> de la base de données
		/// </summary>
		/// <returns>Les familles de la base de données</returns>
        [HttpGet]
        public IEnumerable<Famille> GetAll()
        {
            return _familleRepository.GetAll();
        }

		/// <summary>
		/// Renvoie une <see cref="Famille"/> bien précise à partir de son Id
		/// </summary>
		/// <returns>La famille recherchée</returns>
		/// <param name="id">L'identifiant primaire de la famille à trouver</param>
        [HttpGet("{id}", Name = "GetFamille")]
        public IActionResult GetById(int id)
        {
            var item = _familleRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

		/// <summary>
		/// Créer une nouvelle <see cref="Famille" /> de <see cref="Medicament"/> dans la base de données
		/// </summary>
		/// <returns>Le resultat de la création</returns>
		/// <param name="dtoFamille">La famille à ajouter</param>
        [HttpPost]
        public IActionResult Create([FromBody] DTOFamille dtoFamille)
        {
            if (dtoFamille == null)
            {
                return BadRequest();
            }
			_familleRepository.Add(new Famille()
			{
				Nom = dtoFamille.Nom
			});

			Famille famille = _familleRepository.GetByName(dtoFamille.Nom);

            return CreatedAtRoute("GetFamille", new { id = famille.Id }, famille);
        }

		/// <summary>
		/// Modifie les propriétés d'une <see cref="Famille"/>
		/// </summary>
		/// <returns>Le resultat de la modification apportée</returns>
		/// <param name="id">l'identifiant primaire de la famille à modifier</param>
		/// <param name="famille">Les nouvelles propriétés de la famille</param>
        [HttpPut("{id}")]
        public IActionResult Update(byte id, [FromBody] Famille famille)
        {
            if (famille == null || famille.Id != id)
            {
                return BadRequest();
            }
            var fam = _familleRepository.Find(id);
            if (fam == null)
            {
                return NotFound();
            }
            fam.Nom = famille.Nom;
            fam.Medicaments = famille.Medicaments;
            _familleRepository.Update(fam);
            return new NoContentResult();
        }

		/// <summary>
		/// Suprimmer la <see cref="Famille"/> spécifiée par son id
		/// </summary>
		/// <returns>Le resultat de l'action effecutée, ici une suppression</returns>
		/// <param name="id">L'identifiant primaire de la famille à supprimer</param>
        [HttpDelete("{id}")]
        public IActionResult Delete(byte id)
        {
            var famille = _familleRepository.Find(id);
            if (famille == null)
            {
                return NotFound();
            }
            _familleRepository.Remove(id);
            return new NoContentResult();
        }
    }
}

﻿using System.Collections.Generic;
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

        /// <summary>
        /// Envoie l'ensemble des <see cref="Ville"/> contenant un médecin relié au matricule
        /// </summary>
        /// <param name="matricule">Matricule concerné</param>
        /// <returns></returns>
        [HttpGet("matricule/{matricule}")]
        public IEnumerable<Ville> MedecinsVillesUsingMatricule(string matricule)
        {
            return _villeRepository.MedecinsVillesUsingMatricule(matricule);
        }

        /// <summary>
        /// Envoie l'ensemble des <see cref="Ville"/> du département
        /// </summary>
        /// <param name="departementid">Département concerné</param>
        /// <returns></returns>
        [HttpGet("{departementid}")]
        public IEnumerable<Ville> VillesUsingDepartement(int departementid)
        {
            return _villeRepository.VillesUsingDepartement(departementid);
        }
    }
}

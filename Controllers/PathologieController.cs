using System.Collections.Generic;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Pathologie"/>
	/// </summary>
	[Route("api/[controller]")]
	public class PathologieController
	{
		/// <summary>
		/// Interface du repertoire de requêtes des <see cref="Pathologie"/>
		/// </summary>
		/// <value>L'interface du repository des pathologies</value>
		public IPathologieRepository _pathologieRepository { get; set; }

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="PathologieController"/>
		/// </summary>
		/// <param name="pathologies">Le repository attaché à l'entité <see cref="Pathologie"/></param>
		public PathologieController(IPathologieRepository pathologies)
		{
			_pathologieRepository = pathologies;
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
	}
}

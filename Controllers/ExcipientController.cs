using System;
using System.Collections.Generic;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB
{
	/// <summary>
	/// Contrôleur fournissant les données des <see cref="Excipient"/>
	/// </summary>
	[Route("api/[controller]")]
	public class ExcipientController
	{
		/// <summary>
		/// Interface du repository des <see cref="Excipient"/> permettant l'injéction de dépendance
		/// </summary>
		/// <value>L'interface du repository des excipient</value>
		public IExcipientRepository _excipientRepository { get; set; }

		/// <summary>
		/// Initialise une nouvelle instance de <see cref="ExcipientController"/>
		/// </summary>
		/// <param name="excipients">Le repository attaché à l'entité <see cref="Excipient"/></param>
		public ExcipientController(IExcipientRepository excipients)
		{
			_excipientRepository = excipients;
		}

		/// <summary>
		/// Envoie l'ensemble des <see cref="Excipient"/> de la base de données
		/// </summary>
		/// <returns>Les excipients de la base de données</returns>
		[HttpGet]
		public IEnumerable<Excipient> GetAll()
		{
			return _excipientRepository.GetAll();
		}
	}
}

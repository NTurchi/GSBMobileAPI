using System;
using System.Collections.Generic;
using System.Net.Http;
using APIGSB.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB
{
	/// <summary>
	/// Contrôleur fournissant l'ensemble des <see cref="Metadata">méta données</see> de l'API
	/// </summary>
	[Route("api/[controller]")]
	public class MetadataController
	{
		/// <summary>
		/// Permet d'obtenir les méta données de l'API
		/// </summary>
		/// <returns>Les méta données</returns>
		[HttpGet]
		public List<IDictionary<string, List<Metadata.Metadata>>> GetAll()
        {
			//return _medicamentRepository.GetAll();
			List<IDictionary<string, List<Metadata.Metadata>>> metadataList = new List<IDictionary<string, List<Metadata.Metadata>>>();

			// Ajout des différentes métta données par entités
			metadataList.Add(Metadata.MetadataFactory.Instance.GetMetadata<Medecin>(HttpMethod.Post, HttpMethod.Get, HttpMethod.Get, HttpMethod.Put));
			metadataList.Add(Metadata.MetadataFactory.Instance.GetMetadata<Famille>(HttpMethod.Get, HttpMethod.Get));
			metadataList.Add(Metadata.MetadataFactory.Instance.GetMetadata<Exciptient>(HttpMethod.Get));

			return metadataList;
		}
	}
}

﻿using System.Collections.Generic;
using System.Net.Http;
using APIGSB.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB
{
	/// <summary>
	/// Contrôleur fournissant l'ensemble des <see cref="Metadata">métadonnées</see> de l'API
	/// </summary>
	[Route("api/[controller]")]
	public class MetadataController
	{
		/// <summary>
		/// Permet d'obtenir les métadonnées de l'API
		/// </summary>
		/// <returns>Les méta données</returns>
		[HttpGet]
		public List<IDictionary<string, List<Metadata.Metadata>>> GetAll()
        {
			List<IDictionary<string, List<Metadata.Metadata>>> metadataList = new List<IDictionary<string, List<Metadata.Metadata>>>();

			// Ajout des différentes métadonnées par entités
			metadataList.Add(Metadata
			                 .MetadataFactory
			                 .Instance
			                 .GetMetadata<Medecin>(
				                 HttpMethod.Post, 
                                 HttpMethod.Get, 
                                 HttpMethod.Get, 
                                 HttpMethod.Put, 
                                 HttpMethod.Delete
			                ));
			
			metadataList.Add(Metadata
			                 .MetadataFactory
			                 .Instance
			                 .GetMetadata<Famille>(
				                 HttpMethod.Post, 
				                 HttpMethod.Get, 
				                 HttpMethod.Get, 
				                 HttpMethod.Put, 
				                 HttpMethod.Delete
			                ));
			
			metadataList.Add(Metadata
			                 .MetadataFactory
			                 .Instance.GetMetadata<Medicament>(
				                 HttpMethod.Post, 
				                 HttpMethod.Get, 
				                 HttpMethod.Get, 
				                 HttpMethod.Put, 
				                 HttpMethod.Delete
			                ));

			metadataList.Add(Metadata
			                 .MetadataFactory
			                 .Instance
			                 .GetMetadata<Pathologie>(
				                 HttpMethod.Get, 
				                 HttpMethod.Get
			                ));

			metadataList.Add(Metadata
			                 .MetadataFactory
			                 .Instance
			                 .GetMetadata<Exciptient>(
				                 HttpMethod.Get, 
				                 HttpMethod.Get
			                ));

			metadataList.Add(Metadata
			                 .MetadataFactory
			                 .Instance
			                 .GetMetadata<MedicamentPathologie>(
				                 HttpMethod.Post, 
				                 HttpMethod.Get, 
				                 HttpMethod.Get, 
				                 HttpMethod.Delete
			                ));
			
			metadataList.Add(Metadata
			                 .MetadataFactory
			                 .Instance
			                 .GetMetadata<MedicamentExciptient>(
				                 HttpMethod.Post, 
				                 HttpMethod.Get, 
				                 HttpMethod.Get, 
				                 HttpMethod.Delete
			                ));
			

			return metadataList;
		}
	}
}

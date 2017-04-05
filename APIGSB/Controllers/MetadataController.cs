using System.Collections.Generic;
using System.Net.Http;
using APIGSB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using MediaTypeHeaderValue = System.Net.Http.Headers.MediaTypeHeaderValue;

namespace APIGSB.Controllers
{
    // TODO : Utiliser le fichier json
	/// <summary>
	/// Contrôleur fournissant l'ensemble des <see cref="Metadata">métadonnées</see> de l'API
	/// </summary>
	[Route("api/[controller]")]
	public class MetadataController : Controller
	{
		/// <summary>
		/// Permet d'obtenir les métadonnées de l'API
		/// </summary>
		/// <returns>Les méta données</returns>
		[HttpGet]
		public object GetAll()
        {
            //List<IDictionary<string, List<Metadata.Metadata>>> metadataList = new List<IDictionary<string, List<Metadata.Metadata>>>();

            //// Ajout des différentes métadonnées par entités
            //metadataList.Add(Metadata
            //                 .MetadataFactory
            //                 .Instance
            //                 .GetMetadata<Medecin>(
            //	                 HttpMethod.Post, 
            //                              HttpMethod.Get, 
            //                              HttpMethod.Get, 
            //                              HttpMethod.Put, 
            //                              HttpMethod.Delete
            //                ));

            //metadataList.Add(Metadata
            //                 .MetadataFactory
            //                 .Instance
            //                 .GetMetadata<Famille>(
            //	                 HttpMethod.Post, 
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Put, 
            //	                 HttpMethod.Delete
            //                ));

            //metadataList.Add(Metadata
            //                 .MetadataFactory
            //                 .Instance.GetMetadata<Medicament>(
            //	                 HttpMethod.Post, 
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Put, 
            //	                 HttpMethod.Delete
            //                ));

            //metadataList.Add(Metadata
            //				 .MetadataFactory
            //				 .Instance
            //                 .GetMetadata<Ville>(
            //					 HttpMethod.Get,
            //					 HttpMethod.Get
            //				));

            //metadataList.Add(Metadata
            //                 .MetadataFactory
            //                 .Instance
            //                 .GetMetadata<Pathologie>(
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Get
            //                ));

            //metadataList.Add(Metadata
            //                 .MetadataFactory
            //                 .Instance
            //                 .GetMetadata<Excipient>(
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Get
            //                ));

            //metadataList.Add(Metadata
            //                 .MetadataFactory
            //                 .Instance
            //                 .GetMetadata<MedicamentPathologie>(
            //	                 HttpMethod.Post, 
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Delete
            //                ));

            //metadataList.Add(Metadata
            //                 .MetadataFactory
            //                 .Instance
            //                 .GetMetadata<MedicamentExcipient>(
            //	                 HttpMethod.Post, 
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Get, 
            //	                 HttpMethod.Delete
            //                ));

            //return new { RouteBase = ApiConfiguration.ROUTE_BASE, Metadata = "todo"};
            //string allText = System.IO.File.ReadAllText(@"c:\data.json");

            //object jsonObject = JsonConvert.DeserializeObject(allText);
            //return jsonObject;
            //var resp = new HttpResponseMessage()
            //{
            var content = "{\r\n  \"routeBase\": \"137.74.46.153/api/\",\r\n  \"metadata\": {\r\n    \"medecin\": {\r\n      \"CreateMedecin\": {\r\n        \"method\": \"Post\",\r\n        \"route\": \"medecin\"\r\n      },\r\n      \"FindOne\": {\r\n        \"method\": \"Get\",\r\n        \"route\": \"medecin/{id}\"\r\n      },\r\n      \"GetAllRelatingMatricule\": {\r\n        \"method\": \"Get\",\r\n        \"route\":  \"medecin/matricule/{matricule}\" \r\n      },\r\n      \"GetAllUsingVilleAndMatricule\": {\r\n        \"method\" : \"Get\",\r\n        \"route\": \"medecin/{villeid}/{matricule}\"\r\n      },\r\n      \"GetAllUsingVille\": {\r\n        \"method\" : \"Get\",\r\n        \"route\": \"medecin/ville/{villeid}\"\r\n      }\r\n    },\r\n    \"ville\": {\r\n      \"ListVilles\": {\r\n        \"method\": \"Get\",\r\n        \"route\": \"ville\"  \r\n      },\r\n      \"ListVillesUsingMatricule\": {\r\n        \"method\": \"Get\",\r\n        \"route\": \"ville/{matricule}\"\r\n      },\r\n      \"ListVillesUsingDepartement\": {\r\n        \"method\": \"Get\",\r\n        \"route\": \"ville/{departementid}\"\r\n      } \r\n    }, \r\n    \"medicament\": {\r\n      \"CreateMedicament\": {\r\n        \"method\": \"Get\",\r\n        \"route\": \"medicament\"\r\n      },\r\n      \"GetAllMedicaments\": {\r\n        \"method\": \"Get\",\r\n        \"route\": \"medicament\"\r\n      },\r\n      \"GetOneMedicament\": {\r\n        \"method\": \"Get\",\r\n        \"route\": \"medicament/{id}\"\r\n      }\r\n    },\r\n    \"matricule\": {\r\n      \"ListMatricules\": {\r\n        \"method\": \"Get\",\r\n        \"route\": \"matricule\"\r\n      }\r\n    }\r\n  }\r\n}";
            //};
            return content;
        }
	}
}
    
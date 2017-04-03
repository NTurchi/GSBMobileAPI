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
            var content = "{\"routeBase\":\"http://apigsb20170330020807.azurewebsites.net/api/\",\"metadata\":{\"medecin\":{\"CreateMedecin\":{\"method\":\"Post\",\"route\":\"medecin\"},\"FindOne\":{\"method\":\"Get\",\"route\":\"medecin/{id}\"},\"GetAllRelatingMatricule\":{\"method\":\"Get\",\"route\":\"medecin/matricule/{matricule}\"}},\"ville\":{\"ListVilles\":{\"method\":\"Get\",\"route\":\"ville\"}},\"medicament\":{\"CreateMedicament\":{\"method\":\"Get\",\"route\":\"medicament\"},\"GetAllMedicaments\":{\"method\":\"Get\",\"route\":\"medicament\"},\"GetOneMedicament\":{\"method\":\"Get\",\"route\":\"medicament/{id}\"}},\"matricule\":{\"ListMatricules\":{\"method\":\"Get\",\"route\":\"matricule\"}}}}";
            //};
            return content;
        }
	}
}
    
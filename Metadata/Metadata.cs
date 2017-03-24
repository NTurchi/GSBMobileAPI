using System;
using System.Collections.Generic;
using System.Net.Http;

namespace APIGSB.Metadata
{
	/// <summary>
	/// Classe composé des méta donnée d'une entité pour l'API
	/// </summary>
	public class Metadata
	{
		/// <summary>
		/// Le nom de la route API
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Le type de requête Http
		/// </summary>
		/// <value>La méthode utilisée dans la requête Http</value>
		public string Method { get; set; }

		/// <summary>
		/// La route API pour accéder à la fonctionnalité de l'API voulu
		/// </summary>
		/// <value>The route.</value>
		public string Route { get; set; }

		/// <summary>
		/// Initialise de la meta donnée pour une classe donnée
		/// </summary>
		public Metadata(string entity, HttpMethod methods, bool haveParam = false)
		{
			if (methods == HttpMethod.Post)
			{
				this.Name = $"Create{entity}";
				this.Method = "Post";
				this.Route = $"{ApiConfiguration.ROUTE_BASE}{entity.ToLower()}";
			} else if (methods == HttpMethod.Get && haveParam) {
				this.Name = $"Get{entity}";
				this.Method = "Get";
				this.Route = $"{ApiConfiguration.ROUTE_BASE}{entity.ToLower()}/{{id}}";
			} else if (methods == HttpMethod.Get) {
				this.Name = $"Get{entity}s";
				this.Method = "Get";
				this.Route = $"{ApiConfiguration.ROUTE_BASE}{entity.ToLower()}";
			} else if (methods == HttpMethod.Put) {
				this.Name = $"Update{entity}";
				this.Method = "Get";
				this.Route = $"{ApiConfiguration.ROUTE_BASE}{entity.ToLower()}";
			}
		}
	}
}

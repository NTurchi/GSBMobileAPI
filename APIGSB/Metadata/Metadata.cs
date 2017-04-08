using System.Net.Http;

namespace APIGSB.Metadata
{
	/// <summary>
	/// Classe composé des métadonnées d'une entité pour l'API
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
		/// La route API pour accéder à la fonctionnalité de l'API voulue
		/// </summary>
		/// <value>The route.</value>
		public string Route { get; set; }

		/// <summary>
		/// Initialise de la metadonnée pour une classe donnée
		/// </summary>
		public Metadata(string entity, HttpMethod method, bool haveParam = false)
		{
			if (method == HttpMethod.Post)
			{
				this.Name = $"Create{entity}";
				this.Method = "Post";
				this.Route = $"{entity.ToLower()}";
			} else if (method == HttpMethod.Get && haveParam) {
				this.Name = $"Get{entity}";
				this.Method = "Get";
				this.Route = $"{entity.ToLower()}/{{id}}";
			} else if (method == HttpMethod.Get) {
				this.Name = $"Get{entity}s";
				this.Method = "Get";
				this.Route = $"{entity.ToLower()}";
			} else if (method == HttpMethod.Put) {
				this.Name = $"Update{entity}";
				this.Method = "Get";
				this.Route = $"{entity.ToLower()}";
			} else if (method == HttpMethod.Delete) {
				this.Name = $"Remove{entity}";
				this.Method = "Delete";
				this.Route = $"{entity.ToLower()}";
			}
		}
	}
}

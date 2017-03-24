using System.Collections.Generic;
using System.Net.Http;

namespace APIGSB.Metadata
{
	/// <summary>
	/// Classe qui nous permettra de crée des collections de <see cref="Metadata">métadonnées</see> selon l'entité choisie.
	/// C'est classe sera définie comme un singleton car elle nécessitera qu'une seul instance
	/// </summary>
	public class MetadataFactory
	{
		/// <summary>
		/// Instance encapsulée de <see cref="MetadataFactory"/>
		/// </summary>
		private static MetadataFactory _instance;

		/// <summary>
		/// Initialise une seul et unique instance de <see cref="MetadataFactory"/>
		/// </summary>
		/// <value>The instance.</value>
		public static MetadataFactory Instance {
			get { return _instance ?? (_instance = new MetadataFactory()); }
		}

		/// <summary>
		/// Constructeur privée de la classe <see cref="MetadataFactory" />
		/// </summary>
		private MetadataFactory()
		{ }

		/// <summary>
		/// Retourne une collection de <see cref="Metadata"/> d'une entité donnée
		/// </summary>
		/// <returns>Une collection de métadonnée</returns>
		/// <typeparam name="T">Le type de l'entité dont l'on veut récupéré les métadonnées</typeparam>
		public IDictionary<string, List<Metadata>> GetMetadata<T>(params HttpMethod[] methods)
		{
			// Récuperation du nom de la classe
			string className = typeof(T).ToString().Split('.')[2];

			// Liste des métadonnées
			Dictionary<string, List<Metadata>> entityMetadata = new Dictionary<string, List<Metadata>> ();
			entityMetadata.Add(className, new List<Metadata>());

			// Nombre de requête HTTP de type GET en paramètre, s'il y'en plus d'une c'est que l'on veut aussi la métadonnée 
			// concernant la récupération d'un seul type d'entité
			byte countGet = 0;

			// Pour chaque méthode HTTP précisée, on crée la métadonnée associée
			foreach(HttpMethod method in methods)
			{
				if (method == HttpMethod.Get)
				{
					if (countGet == 1)
					{
						entityMetadata[className].Add(new Metadata(className, method, true));
					} else {
						countGet++;
						entityMetadata[className].Add(new Metadata(className, method));
					}
				} else {
					entityMetadata[className].Add(new Metadata(className, method));
				}
			}

			return entityMetadata;
		}

	}
}

using System;
namespace APIGSB
{
	/// <summary>
	/// Classe contenant les constante de l'application tels que l'adresse de la base de données ou la route de base
	/// de l'API
	/// </summary>
	public class ApiConfiguration
	{
		/// <summary>
		/// Adresse de la base de données
		/// </summary>
		public const string BDD_HOST = "gsbdatabaseserver.database.windows.net";

		/// <summary>
		/// Le nom de la base de données
		/// </summary>
		public const string BDD_NAME = "GSBMOBILEAPIDB";

		/// <summary>
		/// Nom d'utilisateur pour l'accès à la base de données
		/// </summary>
		public const string BDD_USER = "rnrsolutions";

		/// <summary>
		/// Mot de passe du nom d'utilisateur
		/// </summary>
		public const string BDD_PASSWORD = "Admin123!";

		/// <summary>
		/// Route de base de l'API
		/// </summary>
		public const string ROUTE_BASE = "http://localhost:8100/api/";
	}
}

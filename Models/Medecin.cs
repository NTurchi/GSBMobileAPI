using System;
namespace APIGSB.Models
{
	/// <summary>
	/// Classe correspondant à un Médecin
	/// </summary>
	public class Medecin
	{
		/// <summary>
		/// Identifiant primaire de l'objet Médecin
		/// </summary>
		/// <value>L'identifiant</value>
		public int Id { get; set; }

		/// <summary>
		/// Nom du Médecin
		/// </summary>
		/// <value>Le nom</value>
		public string Nom { get; set; }

		/// <summary>
		/// Prénom du Médecin
		/// </summary>
		/// <value>Le prénom</value>
		public string Prenom { get; set; }

		/// <summary>
		/// Code Postal du Médecin
		/// </summary>
		/// <value>Le code postal</value>
		public int CodePostal { get; set; }

		/// <summary>
		/// Url d'une photo du Médecin
		/// </summary>
		/// <value>URL dirigeant vers la photo du médecin</value>
		public string ImgUrl { get; set; }

		/// <summary>
		/// Coordonées latitude du médecin pour pouvoir le situer sur une carte
		/// </summary>
		/// <value>Latitude</value>
		public double Latitude { get; set; }

		/// <summary>
		/// Coordonées longitude du médecin pour pouvoir le situer sur une carte
		/// </summary>
		/// <value>Longitude</value>
		public double Longitude { get; set; }

		/// <summary>
		/// Ville où habite le médecin
		/// </summary>
		/// <value>La ville</value>
		public Ville Ville { get; set; }
	}
}

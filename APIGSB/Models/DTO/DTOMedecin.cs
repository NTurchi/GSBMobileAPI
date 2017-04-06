using System;
using APIGSB.Models;

namespace APIGSBAPIGSB.Models.DTO
{
	/// <summary>
	/// DTO (Data Transfert Object) Objet qui va être envoyé lors d'une requête de type "POST" d'un client.
	/// Ici le DTO est crée pour l'ajout d'une entité <see cref="Medecin"/> dans la base de données
	/// </summary>
	public class DTOMedecin
	{
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
		/// Numéro de telephone du médecin
		/// </summary>
		/// <value>Le numéro de téléphone</value>
		public string Telephone { get; set; }

		/// <summary>
		/// Adresse email du médecin
		/// </summary>
		/// <value>L'adresse email</value>
		public string Email { get; set; }

		/// <summary>
		/// Horaires préférées pour les visites
		/// </summary>
		/// <value>Les préférences horaires pour la visite</value>
		public string HoraireVisite { get; set; }

		/// <summary>
		/// Ville où habite le médecin
		/// </summary>
		/// <value>La ville</value>
		public Ville Ville { get; set; }
	}
}

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIGSB.Models
{
	/// <summary>
	/// Classe correspondant à un Médecin
	/// </summary>
	public class Medecin
	{
        #region property
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
        /// Adresse postal du médecin pour pouvoir accéder à son cabinet
        /// <value>Adresse</value>
        /// </summary>
        public string Adresse { get; set; }
		/// <summary>
		/// Ville où habite le médecin
		/// </summary>
		/// <value>La ville</value>
		public Ville Ville { get; set; }
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

        #endregion property

        #region clés étrangères

        public string VisiteurMatricule { get; set; }

        /// <summary>
        /// L'objet <see cref="Visiteur">Visiteur</see> du médecin
        /// </summary>
        /// <value>La famille du médicament</value>
        public Visiteur Visiteur { get; set; }

		public int VisiteurId { get; set; }

        #endregion clés étrangères

    }
}

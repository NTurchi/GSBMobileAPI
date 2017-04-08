using System.Collections.Generic;

namespace APIGSB.Models
{
	/// <summary>
	/// Classe correspondant à une Ville
	/// </summary>
    public class Ville
    {
		/// <summary>
		/// Identifiant primaire de l'objet Ville
		/// </summary>
		/// <value>L'identifiant</value>
        public int Id { get; set; }

		/// <summary>
		/// Nom de la Ville
		/// </summary>
		/// <value>Le nom</value>
        public string Nom { get; set; }

		/// <summary>
		/// Liste des <see cref="Medecin"/> présents dans cette ville 
		/// </summary>
		/// <value>Les médecins</value>
		public ICollection<Medecin> Medecins { get; set; }

		/// <summary>
		/// Id du département dans lequelle la ville se trouve
		/// </summary>
		/// <value>Identifiant du département</value>
		public int DepartementId { get; set; }
    }
}

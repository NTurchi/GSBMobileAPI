using System.Collections.Generic;

namespace APIGSB.Models
{
	/// <summary>
	/// Classe correspondant à une Pathologie
	/// </summary>
	public class Pathologie
	{
		/// <summary>
		/// Identifiant primaire de l'objet Pathologie
		/// </summary>
		/// <value>L'identifiant</value>
		public int Id { get; set; }

		/// <summary>
		/// Nom de la pathologie
		/// </summary>
		/// <value>Le nom</value>
		public string Libelle { get; set; }

		/// <summary>
		/// Liste des <see cref="Medicament"/> présentant cette Pathologie 
		/// </summary>
		/// <value>Les médicaments présentant cette pathologie</value>
		public ICollection<MedicamentPathologie> MedicamentPathologies { get; set; }
	}
}

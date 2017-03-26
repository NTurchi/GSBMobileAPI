using System;
using System.Collections.Generic;

namespace APIGSB.Models
{
	/// <summary>
	/// Classe correspondant à une Excipient
	/// </summary>
	public class Excipient
	{
		/// <summary>
		/// Identifiant primaire de l'objet Excipient
		/// </summary>
		/// <value>L'identifiant</value>
		public int Id { get; set; }

		/// <summary>
		/// Nom de l'excipient
		/// </summary>
		/// <value>Le nom</value>
		public string Libelle { get; set; }

		/// <summary>
		/// Liste des <see cref="Medicament"/> ayant cet excipient
		/// </summary>
		/// <value>Les médicaments contenant cette excipient</value>
		public ICollection<MedicamentExcipient> MedicamentExcipients { get; set; }
	}
}

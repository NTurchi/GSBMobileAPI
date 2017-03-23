using System;
using System.Collections.Generic;

namespace APIGSB.Models
{
	/// <summary>
	/// Classe correspondant à une Exciptien
	/// </summary>
	public class Exciptient
	{
		/// <summary>
		/// Identifiant primaire de l'objet Exciptient
		/// </summary>
		/// <value>L'identifiant</value>
		public int Id { get; set; }

		/// <summary>
		/// Nom de l'exciptient
		/// </summary>
		/// <value>Le nom</value>
		public string Libelle { get; set; }

		/// <summary>
		/// Liste des <see cref="Medicament"/> ayant cet Exciptient
		/// </summary>
		/// <value>Les médicaments contenant cette exciptient</value>
		public ICollection<MedicamentExciptient> MedicamentExciptients { get; set; }
	}
}

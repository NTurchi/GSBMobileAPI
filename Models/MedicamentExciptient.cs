using System;
namespace APIGSB.Models
{
	/// <summary>
	/// Classe permettant le gestion de la liasion "Many To Many" entre un <see cref="Medicament"/> et ses <see cref="Exciptient />
	/// </summary>
	public class MedicamentExciptient
	{
		/// <summary>
		/// Id du <see cref="Medicament"/>
		/// </summary>
		/// <value>L'identifiant primaire du médicament</value>
		public int MedicamentId { get; set; }

		/// <summary>
		/// Le <see cref="Medicament"/>
		/// </summary>
		/// <value>Le médicament</value>
		public Medicament Medicament { get; set; }

		/// <summary>
		/// Id de l'<see cref="Exciptient"/>
		/// </summary>
		/// <value>L'identifiant primaire de l'exciptient</value>
		public int ExciptientId { get; set; }

		/// <summary>
		/// L'<see cref="Exciptient"/>
		/// </summary>
		/// <value>L'exciptient</value>
		public Exciptient Exciptient { get; set; }
	}
}

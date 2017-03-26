using System;
namespace APIGSB.Models
{
	/// <summary>
	/// Classe permettant le gestion de la liasion "Many To Many" entre un <see cref="Medicament"/> et ses <see cref="Exciptien />
	/// </summary>
	public class MedicamentPathologie
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
		/// Id de la <see cref="Pathologie"/>
		/// </summary>
		/// <value>L'identifiant primaire de la pathologie</value>
		public int PathologieId { get; set; }

		/// <summary>
		/// La <see cref="Pathologie"/>
		/// </summary>
		/// <value>La pathologie</value>
		public Pathologie Pathologie { get; set; }
	}
}
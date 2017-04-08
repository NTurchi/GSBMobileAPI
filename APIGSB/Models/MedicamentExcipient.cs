namespace APIGSB.Models
{
	/// <summary>
	/// Classe permettant le gestion de la liasion "Many To Many" entre un <see cref="Medicament"/> et ses <see cref="Excipient" />
	/// </summary>
	public class MedicamentExcipient
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
		/// Id de l'<see cref="Excipient"/>
		/// </summary>
		/// <value>L'identifiant primaire de l'excipient</value>
		public int ExcipientId { get; set; }

		/// <summary>
		/// L'<see cref="Excipient"/>
		/// </summary>
		/// <value>L'excipient</value>
		public Excipient Excipient { get; set; }
	}
}

using System;
namespace APIGSB.Models.DTO
{
	/// <summary>
	/// DTO (Data Transfert Object) Objet qui va être envoyé lors d'une requête de type "POST" d'un client.
	/// Ici le DTO est crée pour l'ajout d'une entité <see cref="MedicamentExcipient"/> dans la base de données
	/// </summary>
	public class DTOMedicamentExcipient
	{
		/// <summary>
		/// Le <see cref="Medicament"/>
		/// </summary>
		/// <value>Le médicament</value>
		public Medicament Medicament { get; set; }

		/// <summary>
		/// L'<see cref="Excipient"/>
		/// </summary>
		/// <value>L'excipient</value>
		public Excipient Excipient { get; set; }
	}
}

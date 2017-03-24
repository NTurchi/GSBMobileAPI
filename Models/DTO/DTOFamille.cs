using System;
namespace APIGSB.Models.DTO
{
	/// <summary>
	/// DTO (Data Transfert Object) Objet qui va être envoyé lors d'une requête de type "POST" d'un client.
	/// Ici le DTO est crée pour l'ajout d'une entité <see cref="Famille"/> dans la base de données
	/// </summary>
	public class DTOFamille
	{
		/// <summary>
		/// Nom de la famille de médicaments
		/// </summary>
		/// <value>Le nom</value>
		public string Nom { get; set; }
	}
}

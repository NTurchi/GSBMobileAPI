using System;
using System.Collections.Generic;

namespace APIGSB.Models.DTO
{
	/// <summary>
	/// DTO (Data Transfert Object) Objet qui va être envoyé lors d'une requête de type "POST" d'un client.
	/// Ici le DTO est crée pour l'ajout d'une entité <see cref="Medicament"/> dans la base de données
	/// </summary>
	public class DTOMedicament
	{
		#region property

		/// <summary>
		/// Le nom du médicament
		/// </summary>
		/// <value>Le nom</value>
		public string Nom { get; set; }

		/// <summary>
		/// Le statut du médicament
		/// </summary>
		/// <value>Le statut</value>
		public string Status { get; set; }

		/// <summary>
		/// Le principe du médicament
		/// </summary>
		/// <value>Le principe</value>
		public string Principe { get; set; }

		/// <summary>
		/// Le nombre de médicament en stock 
		/// </summary>
		/// <value>Le stock</value>
		public int Stock { get; set; }

		/// <summary>
		/// Le quantité de ce médicament étant actuellement commandée
		/// </summary>
		/// <value>Le nombre de commmande</value>
		public int Commande { get; set; }

		/// <summary>
		/// Le prix à l'unité de ce médicament
		/// </summary>
		/// <value>Le prix</value>
		public decimal Prix { get; set; }

		/// <summary>
		/// La quantité totale de ce médicament
		/// </summary>
		/// <value>La quantité</value>
		public int Quantite { get; set; }

		/// <summary>
		/// Le taux de remboursement par la SECU de ce médicament
		/// </summary>
		/// <value>Le taux de remboursement</value>
		public decimal TauxRemboursement { get; set; }

		/// <summary>
		/// Les indications quant à l'utilisateur de ce médicament
		/// </summary>
		/// <value>Les indications</value>
		public string Indications { get; set; }

		/// <summary>
		/// La voie d'amdministration de ce médicament
		/// </summary>
		/// <value>La méthode d'administration</value>
		public string Administration { get; set; }

		/// <summary>
		/// L'URL de l'image du médicament
		/// </summary>
		/// <value>L'url de l'image</value>
		public string ImgUrl { get; set; }

		#endregion

		#region clés étrangères

		/// <summary>
		/// L'objet <see cref="Famille">Famille</see> du médicament
		/// </summary>
		/// <value>La famille du médicament</value>
		public Famille Famille { get; set; }

		/// <summary>
		/// Les <see cref="Pathologie">pathologies</see> que peut contenir ce médicament
		/// </summary>
		/// <value>Les pathologies</value>
		public ICollection<MedicamentPathologie> MedicamentPathologies { get; set; }

		/// <summary>
		/// Les <see cref="Excipient">exciptiens</see> (ingrédients) contient ce médicament
		/// </summary>
		/// <value>Les excipients</value>
		public ICollection<MedicamentExcipient> MedicamentExcipients { get; set; }

		#endregion
	}
}

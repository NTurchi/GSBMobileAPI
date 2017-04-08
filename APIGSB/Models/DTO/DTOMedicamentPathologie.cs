namespace APIGSB.Models.DTO
{
	/// <summary>
	/// DTO (Data Transfert Object) Objet qui va être envoyé lors d'une requête de type "POST" d'un client.
	/// Ici le DTO est crée pour l'ajout d'une entité <see cref="MedicamentPathologie"/> dans la base de données
	/// </summary>
	public class DTOMedicamentPathologie
	{
		/// <summary>
		/// Le <see cref="Medicament"/>
		/// </summary>
		/// <value>Le médicament</value>
		public Medicament Medicament { get; set; }

		/// <summary>
		/// La <see cref="Pathologie"/>
		/// </summary>
		/// <value>La pathologie</value>
		public Pathologie Pathologie { get; set; }
	}
}

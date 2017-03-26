using System;
using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="MedicamentExcipient"/>
	/// </summary>
	public interface IMedicamentExcipientRepository
	{
		/// <summary>
		/// Obtenir tous les <see cref="Excipient"/> d'un médicament
		/// </summary>
		/// <returns>Une collection d'excipient d'un médicament implémentant l'interface IEnumerable</returns>
		/// <param name="idMedicament">Id du médicament dont l'on veut obtenir ses excipients</param>
		IEnumerable<MedicamentExcipient> GetAll(int idMedicament);

		/// <summary>
		/// Ajoute un <see cref="Excipient"/> à un <see cref="Medicament"/>
		/// </summary>
		/// <param name="medicamentExcipient">l'excipient du médicament à mettre à jour</param>
	    void Add(MedicamentExcipient medicamentExcipient);

		/// <summary>
		/// Supprime un <see cref="Excipient"/> d'un <see cref="Medicament"/> séléctionné 
		/// </summary>
		/// <param name="medicamentExcipient">l'excipient du médicament à supprimer</param>
		void Remove(MedicamentExcipient medicamentExcipient);

		/// <summary>
		/// Supprime une liste d'<see cref="Excipient"/> d'un <see cref="Medicament"/>
		/// </summary>
		/// <param name="idMedicament">Identifiant primaire du médicament</param>
		/// <param name="excipients">La collection d'excipient à supprimer du médicament</param>
		void RemoveRangeExcipient(int idMedicament, List<Excipient> excipients);
	}
}

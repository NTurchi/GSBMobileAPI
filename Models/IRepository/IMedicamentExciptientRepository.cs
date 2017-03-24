using System;
using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="MedicamentExciptient"/>
	/// </summary>
	public interface IMedicamentExciptientRepository
	{
		/// <summary>
		/// Obtenir tous les <see cref="Exciptient"/> d'un médicament
		/// </summary>
		/// <returns>Une collection d'exciptient d'un médicament implémentant l'interface IEnumerable</returns>
		/// <param name="idMedicament">Id du médicament dont l'on veut obtenir ses exciptients</param>
		IEnumerable<MedicamentExciptient> GetAll(int idMedicament);

		/// <summary>
		/// Ajoute un <see cref="Exciptient"/> à un <see cref="Medicament"/>
		/// </summary>
		/// <param name="medicamentExciptient">l'exciptient du médicament à mettre à jour</param>
	    void Add(MedicamentExciptient medicamentExciptient);

		/// <summary>
		/// Supprime un <see cref="Exciptient"/> d'un <see cref="Medicament"/> séléctionné 
		/// </summary>
		/// <param name="medicamentExciptient">l'exciptient du médicament à supprimer</param>
		void Remove(MedicamentExciptient medicamentExciptient);
	}
}

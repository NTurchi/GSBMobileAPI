﻿using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="MedicamentPathologie"/>
	/// </summary>
	public interface IMedicamentPathologieRepository
	{
		/// <summary>
		/// Obtenir toutes les <see cref="Pathologie"/> d'un médicament
		/// </summary>
		/// <returns>Une collection de pathologie d'un médicament implémentant l'interface IEnumerable</returns>
		/// <param name="idMedicament">Id du médicament dont l'on veut obtenir ses pathologies</param>
		IEnumerable<MedicamentPathologie> GetAll(int idMedicament);

		/// <summary>
		/// Ajoute un <see cref="Pathologie"/> à un <see cref="Medicament"/>
		/// </summary>
		/// <param name="medicamentPathologie">l'exciptient du médicament à mettre à jour</param>
		void Add(MedicamentPathologie medicamentPathologie);

		/// <summary>
		/// Supprime un <see cref="Pathologie"/> d'un <see cref="Medicament"/> séléctionné 
		/// </summary>
		/// <param name="medicamentPathologie">La pathologie du médicament à supprimer</param>
		void Remove(MedicamentPathologie medicamentPathologie);

		/// <summary>
		/// Supprime une liste de <see cref="Pathologie"/> d'un <see cref="Medicament"/>
		/// </summary>
		/// <param name="idMedicament">Identifiant primaire du médicament</param>
		/// <param name="pathologies">La collection de pathologie à supprimer du médicament</param>
		void RemoveRangePathologie(int idMedicament, List<Pathologie> pathologies);

		/// <summary>
		/// Ajoute une liste de <see cref="Pathologie"/> à un <see cref="Medicament"/>
		/// </summary>
		/// <param name="idMedicament">Identifiant primaire du médicament</param>
		/// <param name="pathologies">La collection de pathologie à ajouter au médicament</param>
		void AddRangePathologie(int idMedicament, List<Pathologie> pathologies);
	}
}

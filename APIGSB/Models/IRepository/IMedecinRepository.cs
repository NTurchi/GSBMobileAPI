using System;
using System.Collections;
using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="Medecin"/>
	/// </summary>
	public interface IMedecinRepository
	{
		/// <summary>
		/// Obtenir tous les <see cref="Medecin"/> présents dans la base de données
		/// </summary>
		/// <returns>Une collection de médecin implémentant l'interface IEnumerable</returns>
		IEnumerable<Medecin> GetAll();

		/// <summary>
		/// Fonction d'ajout à la base de donnée d'un objet <see cref="Medecin"/>
		/// </summary>
		/// <param name="medecin">Le nouveau médecin à ajouter</param>
		void Add(Medecin medecin);

		/// <summary>
		/// Cherche un <see cref="Medecin"/>en particulier dans la base de données à partir de son identifiant primaire
		/// </summary>
		/// <returns>Le médicament</returns>
		/// <param name="id">L'identifiant du médecin à trouver</param>
		Medecin Find(int id);

		/// <summary>
		/// Supprime un <see cref="Medecin"/>
		/// </summary>
		/// <returns>The remove.</returns>
		/// <param name="id">Identifiant primaire du médecin à supprimer</param>
		void Remove(int id);

		/// <summary>
		/// Mets à jour un <see cref="Medicament"/> 
		/// </summary>
		/// <param name="medecin">Le médecin à mettre à jour</param>
		void Update(Medecin medecin);

		/// <summary>
		/// Retourne un <see cref="Medecin"/> à partir de son nom
		/// </summary>
		/// <returns>Le médecin correspondant</returns>
		/// <param name="nom">Le nom et prenom du médecin</param>
		Medecin GetByName(string nom, string prenom);
	}
}

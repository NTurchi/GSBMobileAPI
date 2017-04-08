using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="Medicament"/>
	/// </summary>
    public interface IMedicamentRepository
    {
		/// <summary>
		/// Obtenir tous les <see cref="Medicament"/> présents dans la base de données
		/// </summary>
		/// <returns>Une collection de médicaments implémentant l'interface IEnumerable</returns>
        IEnumerable<Medicament> GetAll();

        /// <summary>
		/// Obtenir tous les infos de base des <see cref="Medicament"/> présents dans la base de données
		/// </summary>
		/// <returns>Une collection de données de médicaments implémentant l'interface IEnumerable</returns>
        IEnumerable<Medicament> GetAllNameAndFamilly();

        /// <summary>
        /// Fonction d'ajout à la base de donnée d'un objet <see cref="Medicament"/>
        /// </summary>
        /// <param name="medicament">Le nouveau médicament à ajouter</param>
        void Add(Medicament medicament);

		/// <summary>
		/// Cherche un <see cref="Medicament"/>en particulier dans la base de données à partir de son identifiant primaire
		/// </summary>
		/// <returns>Le médicament</returns>
		/// <param name="id">L'identifiant du médicament à trouver</param>
		Medicament Find(int id);
			
		/// <summary>
		/// Supprime un <see cref="Medicament"/>
		/// </summary>
		/// <returns>The remove.</returns>
		/// <param name="id">Identifiant primaire du médicament à supprimer</param>
        void Remove(int id);

		/// <summary>
		/// Mets à jour un <see cref="Medicament"/> 
		/// </summary>
		/// <param name="medicament">Le médicament à mettre à jour</param>
        void Update(Medicament medicament);

		/// <summary>
		/// Retourne un <see cref="Medicament"/> à partir de son nom
		/// </summary>
		/// <returns>Le Medicament correspondant</returns>
		/// <param name="nom">Le nom du médicament à trouver</param>
		Medicament GetByName(string nom);
	}
}

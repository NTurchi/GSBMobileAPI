using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}

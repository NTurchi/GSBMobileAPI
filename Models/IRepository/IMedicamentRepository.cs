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
		/// Obtenir toutes les <see cref="Famille"/> présentes dans la base de données
		/// </summary>
		/// <returns>Une collection implémentant l'interface IEnumerable de médicaments</returns>
        IEnumerable<Medicament> GetAll();

		/// <summary>
		/// Cherche un <see cref="Medicament"/>en particulier dans la base de données à partir de son identifiant primaire
		/// </summary>
		/// <returns>Le médicament</returns>
		/// <param name="id">L'identifiant du médicament</param>
        Medicament Find(int id);
			
		/// <summary>
		/// TODO : Utile ?
		/// </summary>
		/// <returns>The remove.</returns>
		/// <param name="id">Identifier.</param>
        void Remove(int id);

		/// <summary>
		/// TODO: Utile ?
		/// </summary>
		/// <returns>The update.</returns>
		/// <param name="medicament">Medicament.</param>
        void Update(Medicament medicament);
    }
}

using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
    /// <summary>
	/// Interface du repository de l'attribut matricule du visiteur
	/// </summary>
    public interface IMatriculeRepository
    {
        /// <summary>
		/// Obtenir tous les matricules distincts présents dans la base de données
		/// </summary>
		/// <returns>Une collection de matricules implémentant l'interface IEnumerable</returns>
        IEnumerable<string> GetAll();
    }
}

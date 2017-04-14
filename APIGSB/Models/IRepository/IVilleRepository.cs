using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="Ville"/>
	/// </summary>
	public interface IVilleRepository
	{
		/// <summary>
		/// Obtenir toutes les <see cref="Ville"/> présentes dans la base de données
		/// </summary>
		/// <returns>Une collection de pathologie implémentant l'interface IEnumerable</returns>
		IEnumerable<Ville> GetAll();

        /// <summary>
        /// Obtenir toutes les <see cref="Ville"/> possédant un médecin relié au matricule
        /// </summary>
        /// <param name="matricule">Matricule du visiteur pour lequel on recherche les villes des médecins</param>
        /// <returns></returns>
	    IEnumerable<Ville> MedecinsVillesUsingMatricule(string matricule);

        /// <summary>
        /// Obtenir toutes les <see cref="Ville"/> du département correspondant
        /// </summary>
        /// <param name="departementid">Id du département pour lequel on recherche les villes</param>
        /// <returns></returns>
        IEnumerable<Ville> VillesUsingDepartement(int departementid);

	    /// <summary>
	    /// Obtient la ville si celle-ci existe dans la base de données
	    /// </summary>
	    /// <param name="name">Nom de la ville recherchée</param>
	    /// <returns></returns>
	    Ville FindVilleByName(string name);

	}
}

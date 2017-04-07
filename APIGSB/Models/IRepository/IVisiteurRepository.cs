using System;
using System.Collections.Generic;
using APIGSB.Models;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="Visiteur"/>
	/// </summary>
	public interface IVisiteurRepository
	{
		/// <summary>
		/// Cherche un <see cref="Visiteur"/>en particulier dans la base de données à partir de son identifiant primaire
		/// </summary>
		/// <returns>Le visiteur</returns>
		/// <param name="id">L'identifiant du visiteur à trouver</param>
		Visiteur Find(int id);

		/// <summary>
		/// Obtient des <see cref="Visiteur"/> de la base de données ayant ce mot clé en partie dans leur nom
		/// </summary>
		/// <param name="keyword">Mot clé recherché</param>
		/// <returns></returns>
		IEnumerable<Visiteur> FindByNameUsingKeyword(string keyword);

		/// <summary>
		/// Mets à jour un <see cref="Visiteur"/> (plus principalement, les médecins auquels il est assigné) 
		/// </summary>
		/// <param name="visiteur">Le visiteur à mettre à jour</param>
		void Update(Visiteur visiteur);
	}
}

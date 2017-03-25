using System;
using System.Collections.Generic;
using APIGSB.Models;

namespace APIGSB
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
	}
}

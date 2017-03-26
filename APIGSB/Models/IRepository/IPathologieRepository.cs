using System;
using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="Pathologie"/>
	/// </summary>
	public interface IPathologieRepository
	{
		/// <summary>
		/// Obtenir toutes les <see cref="Pathologie"/> présentes dans la base de données
		/// </summary>
		/// <returns>Une collection de pathologie implémentant l'interface IEnumerable</returns>
		IEnumerable<Pathologie> GetAll();
	}
}

using System;
using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="Exciptient"/>
	/// </summary>
	public interface IExciptientRepository
	{
		/// <summary>
		/// Obtenir toutes les <see cref="Exciptient"/> présentes dans la base de données
		/// </summary>
		/// <returns>Une collection de exciptient implémentant l'interface IEnumerable</returns>
		IEnumerable<Exciptient> GetAll();
	}
}

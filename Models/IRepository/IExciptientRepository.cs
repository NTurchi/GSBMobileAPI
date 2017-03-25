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
		/// Obtenir tous les <see cref="Exciptient"/> présents dans la base de données
		/// </summary>
		/// <returns>Une collection d'exciptient implémentant l'interface IEnumerable</returns>
		IEnumerable<Exciptient> GetAll();
	}
}

using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="Excipient"/>
	/// </summary>
	public interface IExcipientRepository
	{
		/// <summary>
		/// Obtenir tous les <see cref="Excipient"/> présents dans la base de données
		/// </summary>
		/// <returns>Une collection d'excipient implémentant l'interface IEnumerable</returns>
		IEnumerable<Excipient> GetAll();
	}
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="Medecin"/>
	/// </summary>
	public interface IMedecinRepository
	{
		/// <summary>
		/// Gets all.
		/// </summary>
		/// <returns>The all.</returns>
		ICollection GetAll();
	}
}

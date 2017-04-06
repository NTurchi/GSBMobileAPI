using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIGSB.Models
{
	/// <summary>
	/// Classe correspondant à une famille de médicaments
	/// </summary>
    public class Famille
    {
		/// <summary>
		/// Identifiant primaire de l'objet Famille
		/// </summary>
		/// <value>L'identifiant</value>
		public int Id { get; set; }

		/// <summary>
		/// Nom de la famille de médicaments
		/// </summary>
		/// <value>Le nom</value>
        public string Nom { get; set; }

		/// <summary>
		/// List des <see cref="Medicament">médicaments<see> appartenant à cette famille
		/// </summary>
		/// <value>Les médicaments</value>
        public ICollection<Medicament> Medicaments { get; set; }
    }
}

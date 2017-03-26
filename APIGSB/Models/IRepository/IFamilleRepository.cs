using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIGSB.Models.IRepository
{
	/// <summary>
	/// Interface du repository de l'objet <see cref="Famille"/>
	/// </summary>
    public interface IFamilleRepository
    {
		/// <summary>
		/// Fonction d'ajout à la base de donnée d'un objet <see cref="Famille"/>
		/// </summary>
		/// <returns>Void</returns>
		/// <param name="famille">La nouvelle famille à ajouter</param>
        void Add(Famille famille);

		/// <summary>
		/// Obtenir toutes les <see cref="Famille"/> présentes dans la base de données
		/// </summary>
		/// <returns>Une collection de médicaments implémentant l'interface IEnumerable</returns>
		IEnumerable<Famille> GetAll();

		/// <summary>
		/// Cherche une <see cref="Famille"/> dans la base de données en particulier à partir de son identifiant primaire
		/// </summary>
		/// <returns>L</returns>
		/// <param name="id">L'identifiant de la <see cref="Famille"/> à retrouver</param>
		Famille Find(int id);

		/// <summary>
		/// Supprime de la base de donnée l'objet <see cref="Famille"/> ayant pour identifiant primaire, celui rentré
		/// en paramètre de la fonction
		/// </summary>
		/// <returns>void</returns>
		/// <param name="id">L'identifiant de la <see cref="Famille" /> à supprimer</param>
        void Remove(byte id);

		/// <summary>
		/// Met à jour un object <see cref="Famille" /> dans la base de donnée
		/// </summary>
		/// <returns>Void</returns>
		/// <param name="famille">L'objet <see cref="Famille"/> à mettre à jour</param>
        void Update(Famille famille);

		/// <summary>
		/// Retourne une <see cref="Famille"/> à partir de son nom
		/// </summary>
		/// <returns>La famille correspondante</returns>
		/// <param name="nom">Le nom de la famille</param>
		Famille GetByName(string nom);
    }
}

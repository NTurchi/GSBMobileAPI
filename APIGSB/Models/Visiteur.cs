using System.Collections.Generic;

namespace APIGSB.Models
{
    public class Visiteur
    {
        #region property
        /// <summary>
        /// Identifiant primaire de l'objet visiteur
        /// </summary>
        /// <value>L'identifiant</value>
        public int Id { get; set; }

        /// <summary>
        /// Matricule du visiteur
        /// </summary>
        /// <value>Le matricule</value>
        public string Matricule { get; set; }
        /// <summary>
        /// Nom du visiteur
        /// </summary>
        /// <value>Le nom</value>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du visiteur
        /// </summary>
        /// <value>Le prénom</value>
        public string Prenom { get; set; }

        /// <summary>
        /// Num de tel du visiteur
        /// </summary>
        /// <value>Le numéro de téléphone</value>
        public string Telephone { get; set; }
        #endregion property

        #region clés étrangères
        /// <summary>
        /// List des <see cref="Medecin"/>médecins appartenant à ce visiteur
        /// </summary>
        /// <value>Les médedecins</value>
        public ICollection<Medecin> Medecins { get; set; }
        #endregion clés étrangères

    }
}

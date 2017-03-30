using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGSB.Models.IRepository;

namespace APIGSB.Models.Repository
{
    /// <summary>
	/// Repository de l'attribut matricule implémentant l'interface <see cref="IMatriculeRepository"/>
	/// </summary>
    public class MatriculeRepository : IMatriculeRepository
    {
        /// <summary>
		/// Base de donnée de l'application, c'est ce qui nous permettra d'effectuer
		/// certaines actions sur la bdd comme l'ajout, la suppression, la modification.
		/// </summary>
        private readonly ApigsbDbContext _context;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="IMatriculeRepository"/>
        /// </summary>
        /// <param name="context">Prend la base de donnée de l'application comme paramètre du constructeur</param>
        public MatriculeRepository(ApigsbDbContext context)
        {
            _context = context;
        }
        public IEnumerable<string> GetAll()
        {
            return _context.Medecin.Select(m => m.VisiteurMatricule).Distinct().AsEnumerable();
        }
    }
}

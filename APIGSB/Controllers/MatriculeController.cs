using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB.Controllers
{
    /// <summary>
	/// Contr�leur fournissant les donn�es des matricules
	/// </summary>
	[Route("api/[controller]")]
    public class MatriculeController : Controller
    {
        /// <summary>
		/// Interface du repertoire de requ�tes des matricules
		/// </summary>
		/// <value>L'interface du repository des matricules</value>
		private IMatriculeRepository _repository;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="MatriculeController"/>
        /// </summary>
        /// <param name="repository">Le repository attach� � l'attribut matricule</param>
        public MatriculeController(IMatriculeRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Envoie l'ensemble des matricules distincts de la base de donn�es
        /// </summary>
        /// <returns>Les matricules distincts de la base de donn�es</returns>
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
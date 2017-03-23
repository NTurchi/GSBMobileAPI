using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGSB.Models;
using Microsoft.AspNetCore.Mvc;
using APIGSB.Models.IRepository;

namespace APIGSB.Controllers
{

    [Route("api/[controller]")]
    public class FamilleController : Controller
    {
        public IFamilleRepository _familleRepository { get; set; }

        public FamilleController(IFamilleRepository familles)
        {
            _familleRepository = familles;
        }

        [HttpGet]
        public IEnumerable<Famille> GetAll()
        {
            return _familleRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetFamille")]
        public IActionResult GetById(int id)
        {
            var item = _familleRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Famille famille)
        {
            if (famille == null)
            {
                return BadRequest();
            }
            _familleRepository.Add(famille);
            return CreatedAtRoute("GetFamille", new {id = famille.Id}, famille);
        }

        [HttpPut("{id}")]
        public IActionResult Update(byte id, [FromBody] Famille famille)
        {
            if (famille == null || famille.Id != id)
            {
                return BadRequest();
            }
            var fam = _familleRepository.Find(id);
            if (fam == null)
            {
                return NotFound();
            }
            fam.Nom = famille.Nom;
            fam.Medicaments = famille.Medicaments;
            _familleRepository.Update(fam);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(byte id)
        {
            var famille = _familleRepository.Find(id);
            if (famille == null)
            {
                return NotFound();
            }
            _familleRepository.Remove(id);
            return new NoContentResult();
        }
    }
}

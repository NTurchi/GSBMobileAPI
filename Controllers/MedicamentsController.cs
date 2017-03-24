using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGSB.Models;
using APIGSB.Models.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace APIGSB.Controllers
{
    [Route("api/[controller]")]
    public class MedicamentController : Controller
    {
        public IMedicamentRepository _medicamentRepository { get; set; }

        public MedicamentController(IMedicamentRepository medicaments)
        {
            _medicamentRepository = medicaments;
        }

        [HttpGet]
        public IEnumerable<Medicament> GetAll()
        {
			return _medicamentRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetMedicament")]
        public IActionResult GetById(int id)
        {
            var item = _medicamentRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Medicament medicament)
        {
            if (medicament == null || medicament.Id != id)
            {
                return BadRequest();
            }
            var med = _medicamentRepository.Find(id);
            if (med == null)
            {
                return NotFound();
            }
            med.Nom = medicament.Nom;
            med.Id = medicament.Id;
            _medicamentRepository.Update(med);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var medicament = _medicamentRepository.Find(id);
            if (medicament == null)
            {
                return NotFound();
            }
            _medicamentRepository.Remove(id);
            return new NoContentResult();
        }
    }
}

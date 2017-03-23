using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIGSB.Models.Repository
{
    public class MedicamentRepository : IMedicamentRepository
    {
        private readonly ApigsbDbContext _context;

        public MedicamentRepository(ApigsbDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Medicament> GetAll()
        {
			return _context.Medicament
				           .Include(m => m.Famille)
				           .Include(m => m.MedicamentPathologies)
				           		.ThenInclude(mp => mp.Pathologie)
				           .Include(m => m.MedicamentExciptients)
				           		.ThenInclude(me => me.Exciptient) 
				           .ToList();
        }


        public Medicament Find(int id)
        {
            return _context.Medicament.Include(m => m.Famille)
						   .Include(m => m.MedicamentPathologies)
							   .ThenInclude(mp => mp.Pathologie)
						   .Include(m => m.MedicamentExciptients)
							   .ThenInclude(me => me.Exciptient)
				           .FirstOrDefault(t => t.Id == id);
        }

        public void Remove(int id)
        {
            var entity = _context.Medicament.First(t => t.Id == id);
            _context.Medicament.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Medicament medicament)
        {
            _context.Medicament.Update(medicament);
            _context.SaveChanges();
        }
    }
}

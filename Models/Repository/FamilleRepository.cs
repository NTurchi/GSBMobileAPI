using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;

namespace APIGSB.Models.Repository
{
    public class FamilleRepository : IFamilleRepository
    {
        private readonly ApigsbDbContext _context;

        public FamilleRepository(ApigsbDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Famille> GetAll()
        {
			var a = _context.Famille.Include(f=>f.Medicaments).AsNoTracking().ToList();
            return a;
        }

        public void Add(Famille famille)
        {
            _context.Famille.Add(famille);
            _context.SaveChanges();
        }

        public Famille Find(int id)
        {
            return _context.Famille.Include(f=>f.Medicaments).FirstOrDefault(t => t.Id == id);
        }

        public void Remove(byte id)
        {
            var entity = _context.Famille.First(t => t.Id == id);
            _context.Famille.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Famille famille)
        {
            _context.Famille .Update(famille);
            _context.SaveChanges();
        }
    }
}

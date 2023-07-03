using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Licenta.Entity;
using Licenta.Helper;

namespace Licenta.Repository
{
    public class PartenerRepository
    {
        private ApplicationDbContext applicationDbContext;
        public PartenerRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public List<Partners> GetAll()
        {
            return applicationDbContext.Partners.ToList();
        }

        public Partners GetById(Guid id)
        {
            return applicationDbContext.Partners.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Partners partner)
        {
            applicationDbContext.Partners.Add(partner);
            applicationDbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var partner = applicationDbContext.Partners.FirstOrDefault(x => x.Id == id);
            applicationDbContext.Partners.Remove(partner);
        }

        public void Edit(Partners partner)
        {
            var edit = applicationDbContext.Partners.FirstOrDefault(x => x.Id == partner.Id);
            edit.Discount = partner.Discount;
            edit.Level = partner.Level;
            edit.Name = partner.Name;
            applicationDbContext.Partners.Update(edit);
            applicationDbContext.SaveChanges();
        }

    }
}

using Licenta.Entity.DTO;
using Licenta.Entity;
using Licenta.Helper;
using Licenta.Repository;

namespace Licenta.Service
{
    public class PartnersService
    {
        private readonly PartenerRepository partnersRepository;

        public PartnersService(ApplicationDbContext applicationDbContext)
        {
            partnersRepository = new PartenerRepository(applicationDbContext);
        }

        public void Create(PartnersDTO partnersDTO)
        {

            Partners partners = new Partners()
            {
                Id = Guid.NewGuid(),
                Discount = partnersDTO.Discount,
                Level = partnersDTO.Level,
                 Name = partnersDTO.Name,
            };

            partnersRepository.Create(partners);


        }

        public List<PartnersDTO> GetAll()
        {
            var partners = partnersRepository.GetAll();
            List<PartnersDTO> result = new List<PartnersDTO>();
            foreach (Partners partner in partners)
            {
                result.Add(new PartnersDTO() {  Id = partner.Id, Name=partner.Name, Level= partner.Level, Discount = partner.Discount });
            }
            return result;
        }

        public PartnersDTO GetById(Guid id)
        {
            var partner = partnersRepository.GetById(id);
            return new PartnersDTO() { Id = partner.Id, Discount = partner.Discount, Level= partner.Level, Name = partner.Name };
        }



        public void Delete(Guid id)
        {
            partnersRepository.Delete(id);
        }

    }
}


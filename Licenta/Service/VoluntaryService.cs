using Licenta.Entity;
using Licenta.Entity.DTO;
using Licenta.Helper;
using Licenta.Repository;

namespace Licenta.Service
{
    public class VoluntaryService
    {
        private readonly VoluntaryRepository voluntaryRepository;

        public VoluntaryService(ApplicationDbContext applicationDbContext)
        {
            voluntaryRepository = new VoluntaryRepository(applicationDbContext);
        }

        public void Create(VoluntaryDto voluntaryDto, string CompanyId)
        {

            Voluntary voluntary = new Voluntary()
            {
                Id = Guid.NewGuid(),
                Reward = voluntaryDto.Reward,
                Name = voluntaryDto.Name,
                Location = voluntaryDto.Location
            };

            voluntaryRepository.Create(voluntary, CompanyId);


        }

        public List<VoluntaryDto> GetAll()
        {
            var voluntaries = voluntaryRepository.GetAll();
            List<VoluntaryDto> result = new List<VoluntaryDto>();
            foreach(Voluntary voluntary in voluntaries)
            {
                result.Add(new VoluntaryDto() {Id=voluntary.Id, Location = voluntary.Location, Name=voluntary.Name, Reward=voluntary.Reward });
            }
            return result;
        }

        public void Delete(Guid id)
        {
            voluntaryRepository.Delete(id);
        }

        public void Edit(VoluntaryDto voluntaryDto)
        {
            var voluntary = new Voluntary() { Location = voluntaryDto.Location, Reward = voluntaryDto.Reward, Name = voluntaryDto.Name, Id = voluntaryDto.Id };
            voluntaryRepository.Edit(voluntary);
        }
    }
}

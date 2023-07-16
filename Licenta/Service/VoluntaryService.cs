using Licenta.Entity;
using Licenta.Entity.DTO;
using Licenta.Helper;
using Licenta.Repository;

namespace Licenta.Service
{
    public class VoluntaryService
    {
        private readonly VoluntaryRepository voluntaryRepository;
        private readonly UserVolutaryRepository userVolutaryRepository;
        private readonly UserRepository userRepository;

        public VoluntaryService(ApplicationDbContext applicationDbContext)
        {
            voluntaryRepository = new VoluntaryRepository(applicationDbContext);
            userVolutaryRepository = new UserVolutaryRepository(applicationDbContext);
            userRepository = new UserRepository(applicationDbContext);
        }

        public void Create(VoluntaryDto voluntaryDto, string CompanyId)
        {
            var Company = userRepository.GetUser(CompanyId);
            
            Voluntary voluntary = new Voluntary()
            {
                Id = Guid.NewGuid(),
                Reward = voluntaryDto.Reward,
                Name = voluntaryDto.Name,
                Location = voluntaryDto.Location,
                 StartDate = voluntaryDto.StartDate,
                  EndDate = voluntaryDto.EndDate,
                   Description = voluntaryDto.Description
            };

            voluntaryRepository.Create(voluntary, Company.ID);


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
            var voluntary = new Voluntary() { Location = voluntaryDto.Location, Reward = voluntaryDto.Reward, Name = voluntaryDto.Name, Id = voluntaryDto.Id, StartDate = voluntaryDto.StartDate, EndDate = voluntaryDto.EndDate, Description = voluntaryDto.Description };
            voluntaryRepository.Edit(voluntary);
        }

        public void Apply(UserVoluntaryDTO applyVoluntaryDto)
        {
            userVolutaryRepository.Create(new User_Voluntarys { Id = Guid.NewGuid(), VoluntaryID = applyVoluntaryDto.VoluntaryID, VolunteerID = applyVoluntaryDto.VolunteerID });
        }

        public int GetReward(Guid userID)
        {
            int score = 0;
            var voluntaries = userVolutaryRepository.SearchByVolunteerID(userID);
            foreach(var voluntary in voluntaries)
            {
                score += voluntaryRepository.GetRewardByID(voluntary);
                userVolutaryRepository.UpdateVolutaryStatus(voluntary, userID);
            }

            return score;

        }

    }
}

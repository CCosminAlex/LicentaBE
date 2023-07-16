using Licenta.Entity;
using Licenta.Entity.DTO;
using Licenta.Helper;

using Licenta.Repository;

namespace Licenta.Service
{
    public class LevelService
    {
       private LevelRepository levelRepository;
        public LevelService(ApplicationDbContext applicationDbContext)
        {
            levelRepository = new LevelRepository(applicationDbContext);
        }

        public  void Create (LevelDto levelDto)
        {
            Level level = new Level()
            {
                Id = Guid.NewGuid(),
                Name = levelDto.Name,
                Scor_end = levelDto.Scor_end,
                Scor_start = levelDto.Scor_start,
            
            };
            levelRepository.Create(level);

            
         }
        
        public LevelDto GetById(Guid id)
        {
            var level = levelRepository.GetById(id);
            return new LevelDto() { Id = level.Id, Name = level.Name, Scor_end = level.Scor_end, Scor_start = level. Scor_start };   

        }
        public List<LevelDto> GetAll()
        {
            var levels = levelRepository.GetAll();
            List<LevelDto> result=new List<LevelDto>();
            foreach (Level level in levels)
            {
                result.Add(new LevelDto() { Id = level.Id, Name = level.Name, Scor_end = level.Scor_end, }
          );
            }
            return result;
        }




    }
}

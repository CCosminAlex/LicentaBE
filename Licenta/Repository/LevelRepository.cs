using Licenta.Entity;
using Licenta.Helper;

namespace Licenta.Repository
{
    public class LevelRepository
    {
        private ApplicationDbContext applicationDbContext;
        public LevelRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public List<Level> GetAll()
        {
            return applicationDbContext.Levels.ToList();
        }

        public Level GetById( Guid id)
        {
            return applicationDbContext.Levels.FirstOrDefault(x => x.Id == id);
        }
        public void Create(Level level)
        {
            applicationDbContext.Levels.Add(level);
            applicationDbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var level = applicationDbContext.Levels.FirstOrDefault(x => x.Id == id);
            applicationDbContext.Levels.Remove(level);
        }

        public void Edit( Level level)
        {
            var edit = applicationDbContext.Levels.FirstOrDefault(x => x.Id == level.Id);    
            edit.Scor_start=level.Scor_start;
            edit.Scor_end=level.Scor_end;
            edit.Name=level.Name;
            applicationDbContext.Levels.Update(edit);
            applicationDbContext.SaveChanges();
        }
    }
}
using Licenta.Entity;
using Licenta.Helper;

namespace Licenta.Repository
{
    public class UserVolutaryRepository
    {

        private ApplicationDbContext dbContext;

        public UserVolutaryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public void Create(User_Voluntarys user_Voluntarys)
        {
            dbContext.User_Voluntarys.Add(user_Voluntarys);
            dbContext.SaveChanges();
        }
        public List<User_Voluntarys> GetAll()
        {
            return dbContext.User_Voluntarys.ToList();

        }
        //for edit
        public User_Voluntarys GetById(Guid User_VoluntarysId)
        {
            return dbContext.User_Voluntarys.FirstOrDefault(x => x.Id == User_VoluntarysId);
        }

        public void Edit(User_Voluntarys user_Voluntarys)
        {
            var editUser_Voluntary = dbContext.User_Voluntarys.FirstOrDefault(x => x.Id == user_Voluntarys.Id);
            editUser_Voluntary.VolunteerID = user_Voluntarys.VolunteerID;
            editUser_Voluntary.VoluntaryID = user_Voluntarys.VoluntaryID;

            dbContext.User_Voluntarys.Update(editUser_Voluntary);
            dbContext.SaveChanges();

        }
        public void Delete(Guid User_VoluntarysId)
        {
            var user_Voluntarys = dbContext.User_Voluntarys.FirstOrDefault(x => x.Id == User_VoluntarysId);
            dbContext.User_Voluntarys.Remove(user_Voluntarys);
            dbContext.SaveChanges();
        }

        public List<Guid> SearchByVolunteerID(Guid volunteerID)
        {
            return dbContext.User_Voluntarys.Where(x => x.VolunteerID == volunteerID && !x.IsRewarded).Select(v => v.VoluntaryID).ToList();

        }

        public void UpdateVolutaryStatus(Guid voluntaryID, Guid volunteerID)
        {
            var edit = dbContext.User_Voluntarys.FirstOrDefault(v=>v.VoluntaryID == voluntaryID && v.VolunteerID == volunteerID && !v.IsRewarded);
            edit.IsRewarded = true;
            dbContext.User_Voluntarys.Update(edit);
            dbContext.SaveChanges();
        }
    }
}

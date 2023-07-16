using Licenta.Entity.DTO;
using Licenta.Helper;

using Licenta.Repository;

namespace Licenta.Service
{
    public class UserService
    {
        public readonly UserRepository userRepository;
        public UserService(ApplicationDbContext applicatioonDbContext)
        {
            userRepository = new UserRepository(applicatioonDbContext);
        }

        public void CreateOrUpdate(UserDTO userDTO)
        {
            var user = userRepository.GetUser(userDTO.Sub_ID);
            if (user == null)
            {
                userDTO.ID = Guid.NewGuid();
            }
            else
            {
                userDTO.ID = user.ID;
            }

            userRepository.Create(new Entity.Users
            {
                Address = userDTO.Address,
                BirthDate = userDTO.BirthDate,
               // CV = userDTO.CV,
                Description = userDTO.Description,
                Email = userDTO.Email,
                ID = userDTO.ID.Value,
                IsCompany = userDTO.IsCompany,
                Name = userDTO.Name,
                Score = userDTO.Score,
                Sub_ID = userDTO.Sub_ID,
            });

        }

        public void Delete(string subID)
        {

            userRepository.Delete(subID);
        }

        public UserDTO Get(string id)
        {
            var user = userRepository.GetUser(id);
            if (user == null) return null;
            return new UserDTO
            {
                Address = user.Address,
                BirthDate = user.BirthDate,
                ID = user.ID,
                //CV = user.CV,
                Description = user.Description,
                Email = user.Email,
                IsCompany = user.IsCompany,
                Name = user.Name,
                Score = user.Score,
                Sub_ID = user.Sub_ID
            };
        }

        public List<UserDTO> GetUsers()
        {
            var userFromDB = userRepository.GetAll().ToList();
            var users = new List<UserDTO>();
            userFromDB.ForEach(user => users.Add(new UserDTO
            {
                Address = user.Address,
                BirthDate = user.BirthDate,
                ID = user.ID,
                //CV = user.CV,
                Description = user.Description,
                Email = user.Email,
                IsCompany = user.IsCompany,
                Name = user.Name,
                Score = user.Score,
                Sub_ID = user.Sub_ID
            }));

            return users;
        }

    }
}

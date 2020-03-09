using System.Collections.Generic;
using System.Threading.Tasks;
using TutorMatch.API.Models;

namespace TutorMatch.API.Data
{
    public interface ITutorRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
         Task<Photo> GetPhoto(int id);
    }
}
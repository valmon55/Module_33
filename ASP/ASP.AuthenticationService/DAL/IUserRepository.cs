using System.Collections.Generic;

namespace ASP.AuthenticationService.DAL
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();
        public User GetByLogin(string login);
    }
}

using System.Collections.Generic;

namespace ASP.AuthenticationService
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();
        public User GetByLogin(string login);
    }
}

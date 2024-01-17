using System.Collections.Generic;

namespace ASP.AuthenticationService
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public User GetByLogin(string login)
        {
            throw new System.NotImplementedException();
        }
    }
}

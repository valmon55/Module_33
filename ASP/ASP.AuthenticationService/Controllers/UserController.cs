using Microsoft.AspNetCore.Mvc;
using System;

namespace ASP.AuthenticationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserController() 
        {
            var logger = new Logger();
            logger.WriteEvent("Сообщение о событии в программе");
            logger.WriteError("Сообщение об ошибки в программе");
        }
        [HttpGet]
        public User GetUser()
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Fedor",
                LastName = "Kr",
                Login = "fedor",
                Password = "1112233qw",
                Email = "fedor@mail.ru"
            };
        }
    }
}

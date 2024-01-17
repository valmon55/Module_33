using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ASP.AuthenticationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private ILogger _logger;
        public UserController(ILogger logger, IMapper mapper) 
        {
            _logger = logger;
            _mapper = mapper;
            logger.WriteEvent("Сообщение о событии в программе");
            logger.WriteError("Сообщение об ошибке в программе");
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
        [HttpGet]
        [Route("viewmodel")]
        public UserViewModel GetUserViewModel()
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "11111122222qq",
                Login = "ivanov"
            };

            var userViewModel = _mapper.Map<UserViewModel>(user);

            return userViewModel;
        }
    }
}

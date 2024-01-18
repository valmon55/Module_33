using ASP.AuthenticationService.DAL;
using AutoMapper;

namespace ASP.AuthenticationService.BLL
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ConstructUsing(v => new UserViewModel(v));

        }
    }
}

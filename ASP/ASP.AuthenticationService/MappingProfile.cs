using AutoMapper;

namespace ASP.AuthenticationService
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

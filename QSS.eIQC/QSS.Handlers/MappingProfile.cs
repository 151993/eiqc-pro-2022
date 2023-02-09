using AutoMapper;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.Handlers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserModel>();
        }
    }
}

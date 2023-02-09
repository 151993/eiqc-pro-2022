using AutoMapper;

namespace QSS.eIQC.UnitTests.Core
{
    public class AutoMapping
    {
        public IMapper GetMapper(Profile profile)
        {
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(profile);
            });
            var mapper = mockMapper.CreateMapper();
            return mapper;
        }
    }
}

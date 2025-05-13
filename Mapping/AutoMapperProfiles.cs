using AutoMapper;

namespace application2.profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
                .ReverseMap();
        }
    }
}


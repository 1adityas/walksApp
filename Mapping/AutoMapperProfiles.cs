using application2.Models.Domain;
using application2.Models.DTO;
using AutoMapper;

namespace application2.profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>().ReverseMap();
            CreateMap<Models.Domain.Region, Models.DTO.AddRegionRequest>().ReverseMap();
            CreateMap<AddRegionRequest, Models.DTO.Region>().ReverseMap();
            CreateMap<UpdateRegionRequest, Models.DTO.Region>().ReverseMap();
            CreateMap<Walk, Models.DTO.AddWalkRequest>().ReverseMap();
            CreateMap<Walk, Models.DTO.WalkDto>().ReverseMap();
            CreateMap<WalkDifficulty, Models.DTO.WalkDifficultyDto>().ReverseMap();
            CreateMap<Walk, Models.DTO.UpdateWalkReqestDto>().ReverseMap();
        }
    }
}
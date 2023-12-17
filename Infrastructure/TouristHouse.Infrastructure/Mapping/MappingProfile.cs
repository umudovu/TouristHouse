using AutoMapper;
using TouristHouse.Application.Dtos.AnnounceDto;
using TouristHouse.Application.Dtos.HomeDto;
using TouristHouse.Application.Dtos.PhotoDto;
using TouristHouse.Application.Features.Commands.AnnounceCommands.HomeAnnounce;
using TouristHouse.Application.Features.Queries.Announce.GetAllAnnounce;
using TouristHouse.Application.Features.Queries.Announce.GetByIdAnnounce;
using TouristHouse.Domain.Entites;
using TouristHouse.Domain.Entites.Category;

namespace TouristHouse.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Home, CreateHomeAnnounceDto>().ReverseMap();
            CreateMap<Home, ResponseHomeAnnounceDto>().ReverseMap();
            CreateMap<Home, UpdateHomeAnnounceDto>().ReverseMap();

            CreateMap<Announce, CreateAnnounceDto>().ReverseMap();
            CreateMap<Announce, ResponseAnnounceDto>().ReverseMap();
            CreateMap<Announce, UpdateAnnounceDto>().ReverseMap();


            CreateMap<Photo, ResponsePhotoDto>().ReverseMap();


            CreateMap<CreateHomeAnnounceDto, CreateHomeAnnounceCommandRequest>().ReverseMap();
            CreateMap<ResponseHomeAnnounceDto, CreateHomeAnnounceCommandResponse>().ReverseMap();
            CreateMap<ResponseAnnounceDto, GetByIdAnnounceQueryResponse>().ReverseMap();
            CreateMap<ResponseAnnounceDto, GetAllAnnounceQueryResponse>().ReverseMap();
        }
    }
}

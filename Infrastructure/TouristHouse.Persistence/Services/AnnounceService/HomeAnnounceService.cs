using AutoMapper;
using TouristHouse.Application.Abstractions.Services;
using TouristHouse.Application.Dtos.HomeDto;
using TouristHouse.Application.Repositories;
using TouristHouse.Domain.Entites.Category;

namespace TouristHouse.Persistence.Services.AnnounceService
{
    public class HomeAnnounceService : IHomeAnnounceService
    {
        private readonly IMapper _mapper;
        private readonly IHomeAnnounceRepository _homeAnnounceRepository;
        private readonly IAnnounceService _announceService;
        public HomeAnnounceService(IMapper mapper, IHomeAnnounceRepository homeAnnounceRepository, IAnnounceService announceService)
        {
            _mapper = mapper;
            _homeAnnounceRepository = homeAnnounceRepository;
            _announceService = announceService;
        }

        public async Task<ResponseHomeAnnounceDto> AddAsync(CreateHomeAnnounceDto createHomeDto)
        {
            Home home = _mapper.Map<Home>(createHomeDto);
            createHomeDto.CreateAnnounceDto.CategoryModelId = home.Id;
            var announceResponce = await _announceService.AddAsync(createHomeDto.CreateAnnounceDto);

            home.AnnounceId = announceResponce.Id;
            await _homeAnnounceRepository.AddAsync(home);
            await _homeAnnounceRepository.SaveAsync();

            return _mapper.Map<ResponseHomeAnnounceDto>(home);
        }

        public Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ResponseHomeAnnounceDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseHomeAnnounceDto> GetSingleAsync(string id)
        {
            var dbModel = await _homeAnnounceRepository.GetByIdAsync(id);
            ResponseHomeAnnounceDto response = _mapper.Map<ResponseHomeAnnounceDto>(dbModel);

            return response;
        }

        public Task<ResponseHomeAnnounceDto> UpdateAsync(UpdateHomeAnnounceDto updateHomeDto)
        {
            throw new NotImplementedException();
        }
    }
}

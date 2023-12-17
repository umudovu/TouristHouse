using TouristHouse.Application.Dtos.HomeDto;

namespace TouristHouse.Application.Abstractions.Services
{
    public interface IHomeAnnounceService
    {
        Task<ResponseHomeAnnounceDto> AddAsync(CreateHomeAnnounceDto createHomeDto);
        Task<ResponseHomeAnnounceDto> UpdateAsync(UpdateHomeAnnounceDto updateHomeDto);
        Task<bool> DeleteAsync(string id);
        Task<ResponseHomeAnnounceDto> GetSingleAsync(string id);
        IQueryable<ResponseHomeAnnounceDto> GetAll();
    }
}

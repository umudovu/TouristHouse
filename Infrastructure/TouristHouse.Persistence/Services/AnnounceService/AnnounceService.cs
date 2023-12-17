using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TouristHouse.Application.Abstractions.Services;
using TouristHouse.Application.Dtos.AnnounceDto;
using TouristHouse.Application.Repositories;
using TouristHouse.Domain.Entites;

namespace TouristHouse.Persistence.Services.AnnounceService
{
    public class AnnounceService : IAnnounceService
    {
        private readonly IMapper _mapper;
        private readonly IAnnounceRepository _announceRepository;
        private readonly IPhotoService _photoService;
        public AnnounceService(IMapper mapper, IAnnounceRepository announceRepository, 
             IPhotoService photoService)
        {
            _mapper = mapper;
            _announceRepository = announceRepository;
            _photoService = photoService;
        }

        public async Task<ResponseAnnounceDto> AddAsync(CreateAnnounceDto createAnnounceDto)
        {
            Announce announce = _mapper.Map<Announce>(createAnnounceDto);
            announce.EndDate = DateTime.Now.AddMonths(12);
            
            var imageResults = await _photoService.AddRangeAsync(createAnnounceDto.Files);
            announce.Photos = new List<Photo>();
            foreach (var p in imageResults)
            {
                Photo photo = new()
                {
                    ImageUrl=p.SecureUri.AbsoluteUri,
                    ImagePublicId=p.PublicId,
                    AnnounceId= announce.Id
                };
                if (imageResults[0] == p) photo.IsMain = true;
                announce.Photos.Add(photo);
            }

            await _announceRepository.AddAsync(announce);
            //await _announceRepository.SaveAsync();

            return _mapper.Map<ResponseAnnounceDto>(announce);
        }

        public ICollection<ResponseAnnounceDto> GetAll()
        {
            var query = _announceRepository.GetAll(false);
            query = query
                .Where(x=>x.IsActive)
                .Include(x => x.Photos)
                .Include(x => x.AnnounceTags)
                .Include(x => x.Country)
                .Include(x => x.City)
                .Include(x => x.Village)
                .OrderByDescending(x=>x.CreatedDate);
            return _mapper.Map<ICollection<ResponseAnnounceDto>>(query);
        }

        public async Task<ResponseAnnounceDto> GetSingleAsync(string id)
        {
            await WatchAsync(id);
            var query = _announceRepository.GetWhere(x => x.Id == id);

            Announce? announce = await query
                .Include(x => x.Photos)
                .Include(x => x.AnnounceTags)
                .Include(x => x.Country)
                .Include(x => x.City)
                .Include(x => x.Village)
                .FirstOrDefaultAsync();
            

            return _mapper.Map<ResponseAnnounceDto>(announce);
        }

        public Task<ResponseAnnounceDto> UpdateAsync(UpdateAnnounceDto updateAnnounce)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> DeleteAsync(string id)
        {
            Announce data = await _announceRepository.GetByIdAsync(id);
            data.IsActive = false;
            return await _announceRepository.SaveAsync();
        }

        public async Task<bool> WatchAsync(string id)
        {
            Announce announce = await _announceRepository.GetByIdAsync(id);
            announce.SeeCount++;
          return await _announceRepository.SaveAsync();
        }
    }
}

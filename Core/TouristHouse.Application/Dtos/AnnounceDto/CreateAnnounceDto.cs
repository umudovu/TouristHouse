using Microsoft.AspNetCore.Http;
using TouristHouse.Application.Dtos.HomeDto;
using TouristHouse.Domain.Entites;

namespace TouristHouse.Application.Dtos.AnnounceDto
{
    public class CreateAnnounceDto
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }

        public string? UserId { get; set; }

        public string? CategoryModelId { get; set; }

        public string? CountryId { get; set; }
        public string? CityId { get; set; }
        public string? VillageId { get; set; }

        public AnnounceCategory Category { get; set; }
        public ICollection<IFormFile>? Files { get; set; }

        public List<AnnounceTag>? AnnounceTags { get; set; }
    }
}

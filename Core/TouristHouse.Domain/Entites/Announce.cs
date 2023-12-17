using TouristHouse.Domain.Entites.Category;
using TouristHouse.Domain.Entites.Common;

namespace TouristHouse.Domain.Entites
{
    public class Announce : BaseEntity
    {

        public string? Title { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }

        public DateTime EndDate { get; set; }
        public int SeeCount { get; set; }

        public string? UserId { get; set; }
        public AppUser? User { get; set; }

        public string? CategoryModelId { get; set; }

        public string? CountryId { get; set; }
        public Country? Country { get; set; }
        public string? CityId { get; set; }
        public City? City { get; set; }
        public string? VillageId { get; set; }
        public Village? Village { get; set; }

        //public double Latitude { get; set; }
        //public double Longitude { get; set; }

        public AnnounceCategory Category { get; set; }
        public List<Photo>? Photos { get; set; }
        public AnnounceStatusType AnnounceStatusType { get; set; } = AnnounceStatusType.Standard;
        public List<AnnounceTag>? AnnounceTags { get; set; }

    }

    public enum AnnounceCategory
    {
        Home=1,
        Hotel,
        Tour,
    }

}

using TouristHouse.Application.Dtos.AnnounceDto;

namespace TouristHouse.Application.Dtos.HomeDto
{
    public class CreateHomeAnnounceDto
    {
        public CreateAnnounceDto? CreateAnnounceDto { get; set; }
        public int FloorCount { get; set; }
        public double Area { get; set; }
        public int RoomCount { get; set; }
        public int BedCount { get; set; }
    }
}

using TouristHouse.Application.Dtos.AnnounceDto;

namespace TouristHouse.Application.Features.Queries.Announce.GetAllAnnounce
{
    public class GetAllAnnounceQueryResponse
    {
        public ICollection<ResponseAnnounceDto>? Items { get; set; }
    }
}

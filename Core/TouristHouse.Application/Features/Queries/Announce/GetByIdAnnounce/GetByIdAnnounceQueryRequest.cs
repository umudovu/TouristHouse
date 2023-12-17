using MediatR;

namespace TouristHouse.Application.Features.Queries.Announce.GetByIdAnnounce
{
    public class GetByIdAnnounceQueryRequest:IRequest<GetByIdAnnounceQueryResponse>
    {
        public string? Id { get; set; }
    }
}

using MediatR;
using TouristHouse.Application.Abstractions.Services;

namespace TouristHouse.Application.Features.Queries.Announce.GetAllAnnounce
{
    public class GetAllAnnounceQueryHandler : IRequestHandler<GetAllAnnounceQueryRequest, GetAllAnnounceQueryResponse>
    {
        private readonly IAnnounceService _announceService;


        public GetAllAnnounceQueryHandler(IAnnounceService announceService)
        {
            _announceService = announceService;
        }

        public async Task<GetAllAnnounceQueryResponse> Handle(GetAllAnnounceQueryRequest request, CancellationToken cancellationToken)
        {
            var result =_announceService.GetAll();
           

            return new() { Items=result};
        }
    }
}

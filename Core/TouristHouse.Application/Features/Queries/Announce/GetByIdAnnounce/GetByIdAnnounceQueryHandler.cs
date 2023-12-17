using MediatR;
using TouristHouse.Application.Abstractions.Services;
using TouristHouse.Application.Dtos.AnnounceDto;

namespace TouristHouse.Application.Features.Queries.Announce.GetByIdAnnounce
{
    public class GetByAllAnnounceQueryHandler : IRequestHandler<GetByIdAnnounceQueryRequest, GetByIdAnnounceQueryResponse>
    {
        private readonly IAnnounceService _announceService;
        public GetByAllAnnounceQueryHandler(IAnnounceService announceService)
        {
            _announceService = announceService;
        }

        public async Task<GetByIdAnnounceQueryResponse> Handle(GetByIdAnnounceQueryRequest request,
            CancellationToken cancellationToken)
        {
            ResponseAnnounceDto response = await _announceService.GetSingleAsync(request.Id);
            //GetByIdAnnounceQueryResponse response = _mapper.Map<GetByIdAnnounceQueryResponse>(result);
            return new() { Response= response };
        }
    }
}

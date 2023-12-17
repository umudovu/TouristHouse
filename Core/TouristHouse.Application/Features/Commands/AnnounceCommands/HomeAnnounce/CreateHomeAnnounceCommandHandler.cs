using AutoMapper;
using MediatR;
using TouristHouse.Application.Abstractions.Services;
using TouristHouse.Application.Dtos.HomeDto;

namespace TouristHouse.Application.Features.Commands.AnnounceCommands.HomeAnnounce
{
    public class CreateHomeAnnounceCommandHandler : IRequestHandler<CreateHomeAnnounceCommandRequest, CreateHomeAnnounceCommandResponse>
    {
        private readonly IHomeAnnounceService _homeAnnounceService;
        private readonly IMapper _mapper;

        public CreateHomeAnnounceCommandHandler(IHomeAnnounceService homeAnnounceService, IMapper mapper)
        {
            _homeAnnounceService = homeAnnounceService;
            _mapper = mapper;
        }

        public async Task<CreateHomeAnnounceCommandResponse> Handle(CreateHomeAnnounceCommandRequest request, CancellationToken cancellationToken)
        {
            var Response = await _homeAnnounceService.AddAsync(request.CreateAnnounceDto);
            return new() { Response=Response};
        }
    }
}

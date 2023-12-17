using MediatR;
using TouristHouse.Application.Abstractions.Services;

namespace TouristHouse.Application.Features.Commands.AnnounceCommands.RemoveAnnounce
{
    public class RemoveAnnounceCommandHandler : IRequestHandler<RemoveAnnounceCommandRequest, RemoveAnnounceCommandResponse>
    {
        readonly IAnnounceService _announceService;

        public RemoveAnnounceCommandHandler(IAnnounceService announceService)
        {
            _announceService = announceService;
        }

        public async Task<RemoveAnnounceCommandResponse> Handle(RemoveAnnounceCommandRequest request, CancellationToken cancellationToken)
        {
            var response = await _announceService.DeleteAsync(request.Id);

            return new () { IsRemoved = response };
        }
    }
}

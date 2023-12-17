using MediatR;

namespace TouristHouse.Application.Features.Commands.AnnounceCommands.RemoveAnnounce
{
    public class RemoveAnnounceCommandRequest:IRequest<RemoveAnnounceCommandResponse>
    {
        public string? Id { get; set; }
    }
}

using MediatR;
using TouristHouse.Domain.Entites;

namespace TouristHouse.Application.Features.Commands.User.CreateRole
{
    public class CreateRoleCommandRequest:IRequest<CreateRoleCommandResponse>
    {
        public AppRole AppRole { get; set; }
    }
}

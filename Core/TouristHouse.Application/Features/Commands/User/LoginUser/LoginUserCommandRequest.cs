using MediatR;

namespace TouristHouse.Application.Features.Commands.User.LoginUser
{
    public class LoginUserCommandRequest : IRequest<LoginUserCommandResponse>
    {
        public string? PhoneNumberOrEmail { get; set; }
        public string? Password { get; set; }
    }
}

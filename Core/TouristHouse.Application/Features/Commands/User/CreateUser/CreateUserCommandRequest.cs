using MediatR;
using TouristHouse.Application.Dtos.User;

namespace TouristHouse.Application.Features.Commands.User.CreateUser
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public CreateUserDto? CreateUserDto { get; set; }
        //public string? Name { get; set; }
        //public string PhoneNumber { get; set; }
        //public string? Email { get; set; }
        //public string? Password { get; set; }
        //public string? PasswordConfirm { get; set; }
    }
}

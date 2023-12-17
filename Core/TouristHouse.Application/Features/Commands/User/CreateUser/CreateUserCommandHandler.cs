using MediatR;
using TouristHouse.Application.Abstractions.Services.User;
using TouristHouse.Application.Dtos.User;

namespace TouristHouse.Application.Features.Commands.User.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        readonly IUserService _userService;

        public CreateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            CreateUserResponse response = await _userService.CreateAsync(request.CreateUserDto);

            return new() { Response=response};
        }
    }
}

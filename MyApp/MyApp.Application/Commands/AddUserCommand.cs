using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
    public record AddUserCommand(Users user): IRequest<Users>;


    public class AddUserCommandHandler(IUserRepository Iuser) : IRequestHandler<AddUserCommand, Users>
    {
        public async Task<Users> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            return await Iuser.AddUser(request.user);
        }

    }
}

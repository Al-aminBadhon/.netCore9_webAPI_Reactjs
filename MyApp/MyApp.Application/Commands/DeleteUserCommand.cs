using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
    public record DeleteUserCommand(int userId): IRequest<bool>;


    public class DeleteUserCommandHandler(IUserRepository Iuser) : IRequestHandler<DeleteUserCommand, bool>
    {
        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return await Iuser.DeleteUser(request.userId);
        }

    }
}

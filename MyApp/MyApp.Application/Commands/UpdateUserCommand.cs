using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
    public record UpdateUserCommand(int userId, Users user): IRequest<Users>;


    public class UpdateUserCommandHandler(IUserRepository userRepo) : IRequestHandler<UpdateUserCommand, Users>
    {
        public async Task<Users> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            //calling to repo
            return await userRepo.UpdateUser(request.userId ,request.user);
        }

    }
}

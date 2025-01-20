using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Queries
{
    public record GetAllUsersQuery() : IRequest<IEnumerable<Users>>;
    public class GetAllUsersQueryHandler(IUserRepository userRepository) : IRequestHandler<GetAllUsersQuery, IEnumerable<Users>>
    {
        public async Task<IEnumerable<Users>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await userRepository.GetAllUsers();
        }
    }
}

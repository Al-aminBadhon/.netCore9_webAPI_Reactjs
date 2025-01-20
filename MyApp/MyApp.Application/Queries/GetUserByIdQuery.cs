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
    public record GetUserByIdQuery(int id) : IRequest<Users>;
    public class GetUserByIdQueryHandler(IUserRepository userRepository) : IRequestHandler<GetUserByIdQuery, Users>
    {
        public async Task<Users> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await userRepository.GetUserByID(request.id);
        }
    }
}

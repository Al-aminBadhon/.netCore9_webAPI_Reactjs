using MyApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<Users>> GetAllUsers();
        Task<Users> GetUserByID(int id);
        Task<Users> AddUser(Users user);
    }
}

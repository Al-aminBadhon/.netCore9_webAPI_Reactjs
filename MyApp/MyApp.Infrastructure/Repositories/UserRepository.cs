using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repositories
{
    public class UserRepository(AppDbContext dbContext) : IUserRepository
    {
        public async Task<IEnumerable<Users>> GetAllUsers()
        {
            return await dbContext.Users.ToListAsync();
        }

        public async Task<Users> GetUserByID(int id)
        {
            return await dbContext.Users.FirstOrDefaultAsync(x => x.UserId == id);
        }

        public async Task<Users> AddUser(Users user)
        {
            user.UserId = 0;
            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;
            user.IsActive = true;
            dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync();
            return user;
        }
    }
}

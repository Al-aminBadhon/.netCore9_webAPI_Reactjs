using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext (options)
    {
        public DbSet<Users> Users { get; set; }
    }
}

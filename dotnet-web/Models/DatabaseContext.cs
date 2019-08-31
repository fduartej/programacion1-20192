using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnet_web.models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<Follower> Followers { get; set; }

    }
}
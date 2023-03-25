using CQRS.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Api.Data
{
    public class DataDB: DbContext
    {
        protected readonly IConfiguration Configuration;
        public DataDB(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<User> User { get; set; }

    }
}

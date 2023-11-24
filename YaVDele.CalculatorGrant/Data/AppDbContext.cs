using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using YaVDele.CalculatorGrant.Data.Entities;

namespace YaVDele.CalculatorGrant.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("AppDB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VolounteerJobs>()
                .ToTable("VolounteerJobs");
        }
    }
}

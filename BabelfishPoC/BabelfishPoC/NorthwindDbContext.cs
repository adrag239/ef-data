using Microsoft.EntityFrameworkCore;

namespace BabelfishPoC
{
    public class NorthwindDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=NorthwindTraders;Trusted_Connection=True;MultipleActiveResultSets=true;Application Name=NorthwindTraders;");
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NorthwindDbContext).Assembly);
        }
    }
}

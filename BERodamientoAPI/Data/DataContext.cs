using Microsoft.EntityFrameworkCore;

namespace BERodamientoAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Driver> Drivers { get; set; }


    }
}

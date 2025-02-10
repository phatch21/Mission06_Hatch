using Microsoft.EntityFrameworkCore;

namespace Mission06_Hatch.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } // Creates Movies table
    }
}

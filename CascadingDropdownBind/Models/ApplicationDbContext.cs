using Microsoft.EntityFrameworkCore;

namespace CascadingDropdownBind.Models
{
    public class ApplicationDbContext :DbContext 
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
                
        }


        public DbSet<Country> countries { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}

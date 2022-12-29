using Microsoft.EntityFrameworkCore;

namespace Cars_Back.Models
{
    public class LocataireDbContext : DbContext
    {
        //Create constructor
        public LocataireDbContext(DbContextOptions<LocataireDbContext> options) : base(options)
        {
        }

        //Create DbSet
        public DbSet<Locataire> Locataires { get; set; }
    }
}

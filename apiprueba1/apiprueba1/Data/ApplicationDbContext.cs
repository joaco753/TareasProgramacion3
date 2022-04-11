using apiprueba1.Models;
using Microsoft.EntityFrameworkCore;

namespace apiprueba1.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        public DbSet<Productos> Productos { get; set; }

    }
}

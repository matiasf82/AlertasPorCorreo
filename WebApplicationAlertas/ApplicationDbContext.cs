using Microsoft.EntityFrameworkCore;
using Entidades;

namespace WebApplicationAlertas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Correo> Correos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Hidalgo_Yanez.Models
{
    public class AplicationDbContext: DbContext
    {
        //public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options ) : base(options)
        {
 
        }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Genero> Generos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Oficina_API.Models
{
   public class PecaContext : DbContext
   {
      public PecaContext(DbContextOptions<PecaContext> options)
             : base(options)
      {
      }

      public DbSet<Peca> Pecas { get; set; } = null!;
   }
}

using Microsoft.EntityFrameworkCore;

namespace Oficina_API.Models
{
   public class MovimentoContext : DbContext
   {
      public MovimentoContext(DbContextOptions<MovimentoContext> options)
             : base(options)
      {
      }

      public DbSet<Movimento> Movimentos { get; set; } = null!;
      public DbSet<Peca> Pecas { get; set; } = null!;
   }
}

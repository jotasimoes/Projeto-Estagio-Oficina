using Microsoft.EntityFrameworkCore;

namespace Oficina_API.Models
{
   public class ReparacaoContext : DbContext
   {
      public ReparacaoContext(DbContextOptions<ReparacaoContext> options)
            : base(options)
      {
      }

      public DbSet<Reparacao> Reparacoes { get; set; } = null!;
   }
}

using Microsoft.EntityFrameworkCore;

namespace Oficina_API.Models
{
   public class Peca_reparacaoContext : DbContext
   {
      public Peca_reparacaoContext(DbContextOptions<Peca_reparacaoContext> options)
             : base(options)
      {
      }
      public DbSet<Peca_reparacao> Pecas_reparacoes { get; set; } = null!;
      public DbSet<Reparacao> Reparacoes { get; set; } = null!;
      public DbSet<Movimento> Movimentos { get; set; } = null!;
      public DbSet<Peca> Pecas { get; set; } = null!;

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Peca_reparacao>()
             .HasKey(pr => new { pr.Id_peca, pr.Id_movimento, pr.Id_reparacao });
      }
   }
}

using Microsoft.EntityFrameworkCore;
using Oficina_API.Models;

namespace Oficina_API.Models
{
   public class Peca_reparacaoDTOContext : DbContext
   {
      public Peca_reparacaoDTOContext(DbContextOptions<Peca_reparacaoDTOContext> options) : base(options)
      {
      }

      public DbSet<Peca_reparacaoDTO> Pecas_reparacoesDTO { get; set; } = null!;


      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Peca_reparacaoDTO>()
             .HasKey(pr => new { pr.Id_peca, pr.Id_movimento, pr.Id_reparacao });
      }

   }
}

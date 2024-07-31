using System.ComponentModel.DataAnnotations;

namespace Oficina_API.Models
{
   public class Peca_reparacao
   {
      [Key]
      [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Chavepeca")]
      public int Id_peca { get; set; }
      [Key]
      [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Chavemovimento")]
      public int Id_movimento { get; set; }
      [Key]
      [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Chavereparacao")]
      public int Id_reparacao { get; set; }
      //public string? Descricao_peca { get; set; }
      public int Quantidade_pecas_reparacoes { get; set; }
     
   }

   public class Chavemovimento
   {
      public int Id_movimento { get; set; }
      public ICollection<Movimento>? Movimentos { get; set; }
   }

   public class Chavereparacao
   {
      public int Id_reparacao { get; set; }
      public ICollection<Reparacao>? Reparacoes { get; set; }
   }
}

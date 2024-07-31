using System.ComponentModel.DataAnnotations;


namespace Oficina_API.Models
{
   public class Peca_reparacaoDTO
   {
      [Key]
      public int Id_peca { get; set; }
      [Key]
      public int Id_reparacao { get; set; }
      [Key]
      public int Id_movimento { get; set; }
      public int Quantidade_pecas_reparacoes { get; set; }
      public string? Descricao_peca { get; set; }
   }




}

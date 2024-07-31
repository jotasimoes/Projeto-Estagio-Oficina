using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaV2.Models
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
      public string Descricao_peca { get; set; }
      public string PecaComDescricao
      {
         get
         {
            if (!string.IsNullOrWhiteSpace(Descricao_peca))
               return Id_peca.ToString() + " - " + Descricao_peca;
            return Id_peca.ToString();
         }

      }
   }
}

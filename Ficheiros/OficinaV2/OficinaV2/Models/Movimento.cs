using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaV2.Models
{
   public class Movimento
   {     
         [Key]
         public int Id_movimento { get; set; }
         public string Descricao_movimento { get; set; }
         public int Quantidade_movimento { get; set; }
         public DateTime Data_movimento { get; set; }
         public int Operacao { get; set; }
         public int QuantidadeVezesOperacao => Quantidade_movimento * Operacao;

         [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Chavepeca")]
         public int Id_peca { get; set; }
      }
      public class Chavepeca
      {
         public int Id_peca { get; set; }
         public ICollection<Peca> Pecas { get; set; }
      }   
}

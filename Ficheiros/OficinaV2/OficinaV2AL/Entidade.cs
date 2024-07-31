using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaV2AL
{
   public class Peca
   {
      public int Id_peca { get; set; }
      public string Descricao_peca { get; set; }
      public decimal Preco_peca { get; set; }
   }

   public class Movimento
   {
      public int Id_movimento { get; set; }
      public string Descricao_movimento { get; set; }
      public int Quantidade_movimento { get; set; }
      public DateTime Data_movimento { get; set; }
      public int Operacao { get; set; }
      public int QuantidadeVezesOperacao => Quantidade_movimento * Operacao;
   }

   public class PecaReparacao
   {
      public int Id_peca { get; set; }
      public string Descricao_peca { get; set; }
      public int Quantidade_pecas_reparacoes { get; set; }
   }
   public class Reparacao
   {
      public int Id_reparacao { get; set; }
      public string Matricula { get; set; }
      public DateTime Data { get; set; }
      public string Cor { get; set; }
      public string Marca { get; set; }
      public string Estado { get; set; }
   }
}

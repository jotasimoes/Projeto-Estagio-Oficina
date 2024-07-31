using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaV2.Models
{
   public class PecaStock
   {
      public Peca Peca { get; set; }
      public string Descricao_peca { get; set; }
      public int Stock { get; set; }
   }
}

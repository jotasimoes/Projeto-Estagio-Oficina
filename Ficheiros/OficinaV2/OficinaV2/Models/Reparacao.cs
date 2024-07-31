using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaV2.Models
{
   public class Reparacao
   {
      [Key]
      public int Id_reparacao { get; set; }
      public string Matricula { get; set; }
      public DateTime Data_reparacao { get; set; }
      public string Cor { get; set; }
      public string Marca { get; set; }
      public string Estado { get; set; }

      
   }
  
}

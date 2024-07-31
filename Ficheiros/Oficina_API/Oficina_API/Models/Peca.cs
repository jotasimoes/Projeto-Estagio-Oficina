using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Oficina_API.Models
{
   public class Peca 
   {
      [Key]
      public int Id_peca { get; set; }
      public string? Descricao_peca { get; set; }
      public decimal Preco_peca { get; set; }     
   }
  
}

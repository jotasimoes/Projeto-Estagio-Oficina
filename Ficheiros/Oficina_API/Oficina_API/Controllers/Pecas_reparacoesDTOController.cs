using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oficina_API.Models;



namespace Oficina_API.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class Pecas_reparacoesDTOController : ControllerBase
   {
      private readonly Peca_reparacaoDTOContext _context;

      public Pecas_reparacoesDTOController(Peca_reparacaoDTOContext context)
      {
         _context = context;
      }

      [HttpGet("reparacoes/{id_reparacao}")]
      public async Task<ActionResult<List<Peca_reparacaoDTO>>> GetAllPecasReparacoesPorReparacao(int id_reparacao)
      {
         var pecas_reparacoes_dto = await _context.Pecas_reparacoesDTO
     .FromSqlRaw("SELECT pr.*, p.descricao_peca " +
         "FROM Pecas_Reparacoes pr " +
         "INNER JOIN Pecas p ON p.id_peca = pr.id_peca " +
         "INNER JOIN Reparacoes r ON r.id_reparacao = pr.id_reparacao " +
         "WHERE r.id_reparacao = {0}", id_reparacao)
     .ToListAsync();

         return pecas_reparacoes_dto;
      }






   }
}

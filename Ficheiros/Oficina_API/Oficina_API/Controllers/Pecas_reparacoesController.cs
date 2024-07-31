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
    public class Pecas_reparacoesController : ControllerBase
    {
        private readonly Peca_reparacaoContext _context;

        public Pecas_reparacoesController(Peca_reparacaoContext context)
        {
            _context = context;
        }








      //[HttpGet("reparacoes/{id_reparacao}")]
      //public async Task<ActionResult<List<Peca_reparacaoDTO>>> GetAllPecasReparacoesPorReparacao(int id_reparacao)
      //{
      //   var pecas_reparacoes = await _context.Pecas_reparacoes
      //       .FromSqlRaw("SELECT pr.*, p.descricao_peca " +
      //           "FROM Pecas_Reparacoes pr " +
      //           "INNER JOIN Pecas p ON p.id_peca = pr.id_peca " +
      //           "INNER JOIN Reparacoes r ON r.id_reparacao = pr.id_reparacao " +
      //           "WHERE r.id_reparacao = {0}", id_reparacao)
      //       .ToListAsync();

      //   var pecas_reparacoes_dto = pecas_reparacoes.Select(pr => new Peca_reparacaoDTO
      //   {
      //      Id_peca = pr.Id_peca,
      //      Id_reparacao = pr.Id_reparacao,
      //      Id_movimento = pr.Id_movimento,
      //      Quantidade_pecas_reparacoes = pr.Quantidade_pecas_reparacoes,
      //      Descricao_peca = pr.Descricao_peca
      //   }).ToList();

      //   return pecas_reparacoes_dto;
      //}












      // GET: api/Pecas_reparacoes
      [HttpGet]
        public async Task<ActionResult<IEnumerable<Peca_reparacao>>> GetPecas_reparacoes()
        {
          if (_context.Pecas_reparacoes == null)
          {
              return NotFound();
          }
            return await _context.Pecas_reparacoes.ToListAsync();
        }

        // GET: api/Pecas_reparacoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Peca_reparacao>> GetPeca_reparacao(int id)
        {
          if (_context.Pecas_reparacoes == null)
          {
              return NotFound();
          }
            var peca_reparacao = await _context.Pecas_reparacoes.FindAsync(id);

            if (peca_reparacao == null)
            {
                return NotFound();
            }

            return peca_reparacao;
        }

        // PUT: api/Pecas_reparacoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeca_reparacao(int id, Peca_reparacao peca_reparacao)
        {
            if (id != peca_reparacao.Id_peca)
            {
                return BadRequest();
            }

            _context.Entry(peca_reparacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Peca_reparacaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pecas_reparacoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Peca_reparacao>> PostPeca_reparacao(Peca_reparacao peca_reparacao)
        {
          if (_context.Pecas_reparacoes == null)
          {
              return Problem("Entity set 'Peca_reparacaoContext.Pecas_reparacoes'  is null.");
          }
            _context.Pecas_reparacoes.Add(peca_reparacao);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Peca_reparacaoExists(peca_reparacao.Id_peca))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPeca_reparacao", new { id = peca_reparacao.Id_peca }, peca_reparacao);
        }

        // DELETE: api/Pecas_reparacoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeca_reparacao(int id)
        {
            if (_context.Pecas_reparacoes == null)
            {
                return NotFound();
            }
            var peca_reparacao = await _context.Pecas_reparacoes.FindAsync(id);
            if (peca_reparacao == null)
            {
                return NotFound();
            }

            _context.Pecas_reparacoes.Remove(peca_reparacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }



      ////GET: api/Pecas_reparacoes de uma certa reparação
      //[HttpGet("reparacoes/{id_reparacao}")]
      //public async Task<ActionResult<List<Peca_reparacao>>> GetAllPecasReparacoesPorReparacao(int id_reparacao)
      //{
      //   var pecas_reparacoes = await _context.Pecas_reparacoes
      //       .FromSqlRaw("SELECT pr.*, p.descricao_peca " +
      //           "FROM Pecas_Reparacoes pr " +
      //           "INNER JOIN Pecas p ON p.id_peca = pr.id_peca " +
      //           "INNER JOIN Reparacoes r ON r.id_reparacao = pr.id_reparacao " +
      //           "WHERE r.id_reparacao = {0}", id_reparacao)
      //       .ToListAsync();
      //   return pecas_reparacoes;
      //}







      private bool Peca_reparacaoExists(int id)
        {
            return (_context.Pecas_reparacoes?.Any(e => e.Id_peca == id)).GetValueOrDefault();
        }
    }
}

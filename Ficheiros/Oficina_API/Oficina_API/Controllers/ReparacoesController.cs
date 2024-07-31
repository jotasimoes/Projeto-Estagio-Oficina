using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oficina_API.Models;

namespace Oficina_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReparacoesController : ControllerBase
    {
        private readonly ReparacaoContext _context;

        public ReparacoesController(ReparacaoContext context)
        {
            _context = context;
        }

        // GET: api/Reparacoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reparacao>>> GetReparacoes()
        {
          if (_context.Reparacoes == null)
          {
              return NotFound();
          }
            return await _context.Reparacoes.ToListAsync();
        }

        // GET: api/Reparacoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reparacao>> GetReparacao(int id)
        {
          if (_context.Reparacoes == null)
          {
              return NotFound();
          }
            var reparacao = await _context.Reparacoes.FindAsync(id);

            if (reparacao == null)
            {
                return NotFound();
            }

            return reparacao;
        }

        // PUT: api/Reparacoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReparacao(int id, Reparacao reparacao)
        {
            if (id != reparacao.Id_reparacao)
            {
                return BadRequest();
            }

            _context.Entry(reparacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReparacaoExists(id))
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

        // POST: api/Reparacoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Reparacao>> PostReparacao(Reparacao reparacao)
        {
          if (_context.Reparacoes == null)
          {
              return Problem("Entity set 'ReparacaoContext.Reparacoes'  is null.");
          }
            _context.Reparacoes.Add(reparacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReparacao", new { id = reparacao.Id_reparacao }, reparacao);
        }

        // DELETE: api/Reparacoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReparacao(int id)
        {
            if (_context.Reparacoes == null)
            {
                return NotFound();
            }
            var reparacao = await _context.Reparacoes.FindAsync(id);
            if (reparacao == null)
            {
                return NotFound();
            }

            _context.Reparacoes.Remove(reparacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReparacaoExists(int id)
        {
            return (_context.Reparacoes?.Any(e => e.Id_reparacao == id)).GetValueOrDefault();
        }
    }
}

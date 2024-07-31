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
    public class MovimentosController : ControllerBase
    {
        private readonly MovimentoContext _context;

        public MovimentosController(MovimentoContext context)
        {
            _context = context;
        }

        // GET: api/Movimentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movimento>>> GetMovimentos()
        {
          if (_context.Movimentos == null)
          {
              return NotFound();
          }
            return await _context.Movimentos.ToListAsync();
        }

        // GET: api/Movimentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movimento>> GetMovimento(int id)
        {
          if (_context.Movimentos == null)
          {
              return NotFound();
          }
            var movimento = await _context.Movimentos.FindAsync(id);

            if (movimento == null)
            {
                return NotFound();
            }

            return movimento;
        }

        // PUT: api/Movimentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovimento(int id, Movimento movimento)
        {
            if (id != movimento.Id_movimento)
            {
                return BadRequest();
            }

            _context.Entry(movimento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovimentoExists(id))
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

        // POST: api/Movimentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movimento>> PostMovimento(Movimento movimento)
        {
          if (_context.Movimentos == null)
          {
              return Problem("Entity set 'MovimentoContext.Movimentos'  is null.");
          }
            _context.Movimentos.Add(movimento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMovimento", new { id = movimento.Id_movimento }, movimento);
        }

        // DELETE: api/Movimentos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovimento(int id)
        {
            if (_context.Movimentos == null)
            {
                return NotFound();
            }
            var movimento = await _context.Movimentos.FindAsync(id);
            if (movimento == null)
            {
                return NotFound();
            }

            _context.Movimentos.Remove(movimento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

      // GET: api/Movimentos de uma certa peça
      [HttpGet("pecas/{id_peca}")]
      public async Task<ActionResult<List<Movimento>>> GetAllMovimentosByPeca(int id_peca)
      {
         var movimentos = await _context.Movimentos.Where(m => m.Id_peca == id_peca).ToListAsync();
         return movimentos;
      }

      // DELETE: api/Movimento de uma certa peca
      [HttpDelete("{id_movimento}/pecas/{id_peca}")]
      public async Task<IActionResult> DeleteMovimentoByPeca(int id_peca, int id_movimento)
      {
         if (_context.Movimentos == null)
         {
            return NotFound();
         }

         var movimento = await _context.Movimentos.SingleOrDefaultAsync(m => m.Id_peca == id_peca && m.Id_movimento == id_movimento);
         if (movimento == null)
         {
            return NotFound();
         }

         _context.Movimentos.Remove(movimento);
         await _context.SaveChangesAsync();

         return NoContent();
      }

      // POST: api/Movimentos de uma certa peça
      [HttpPost("pecas/{id_peca}/movimentos")]
      public async Task<ActionResult<Movimento>> AdicionarMovimentoByPeca(int id_peca, Movimento movimento)
      {
         var peca = await _context.Pecas.FindAsync(id_peca);

         if (peca == null)
         {
            return NotFound();
         }

         movimento.Id_peca = id_peca;

         _context.Movimentos.Add(movimento);
         await _context.SaveChangesAsync();

         return CreatedAtAction(nameof(GetAllMovimentosByPeca), new { id_peca = id_peca }, movimento);
      }



      private bool MovimentoExists(int id)
        {
            return (_context.Movimentos?.Any(e => e.Id_movimento == id)).GetValueOrDefault();
        }

     

   }
}

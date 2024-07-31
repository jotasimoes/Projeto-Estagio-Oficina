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
    public class PecasController : ControllerBase
    {
        private readonly PecaContext _context;

        public PecasController(PecaContext context)
        {
            _context = context;
        }

        // GET: api/Pecas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Peca>>> GetPecas()
        {
          if (_context.Pecas == null)
          {
              return NotFound();
          }
            return await _context.Pecas.ToListAsync();
        }

        // GET: api/Pecas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Peca>> GetPeca(int id)
        {
          if (_context.Pecas == null)
          {
              return NotFound();
          }
            var peca = await _context.Pecas.FindAsync(id);

            if (peca == null)
            {
                return NotFound();
            }

            return peca;
        }

        // PUT: api/Pecas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPeca(int id, Peca peca)
        {
            if (id != peca.Id_peca)
            {
                return BadRequest();
            }

            _context.Entry(peca).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PecaExists(id))
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

        // POST: api/Pecas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Peca>> PostPeca(Peca peca)
        {
          if (_context.Pecas == null)
          {
              return Problem("Entity set 'PecaContext.Pecas'  is null.");
          }
            _context.Pecas.Add(peca);
            await _context.SaveChangesAsync();

         //return CreatedAtAction("GetPeca", new { id = peca.Id_peca }, peca);
         return CreatedAtAction(nameof(GetPeca), new { id = peca.Id_peca }, peca);
      }

        // DELETE: api/Pecas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePeca(int id)
        {
            if (_context.Pecas == null)
            {
                return NotFound();
            }
            var peca = await _context.Pecas.FindAsync(id);
            if (peca == null)
            {
                return NotFound();
            }

            _context.Pecas.Remove(peca);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PecaExists(int id)
        {
            return (_context.Pecas?.Any(e => e.Id_peca == id)).GetValueOrDefault();
        }
    }
}

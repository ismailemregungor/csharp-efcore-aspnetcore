using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNETCOREWebApiDbFirstUrunApi.Models;

namespace ASPNETCOREWebApiDbFirstUrunApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlersController : ControllerBase
    {
        private readonly ModelContext _context;

        public UrunlersController(ModelContext context)
        {
            _context = context;
        }

        // GET: api/Urunlers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Urunler>>> GetUrunlers()
        {
          if (_context.Urunlers == null)
          {
              return NotFound();
          }
            return await _context.Urunlers.ToListAsync();
        }

        // GET: api/Urunlers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Urunler>> GetUrunler(int id)
        {
          if (_context.Urunlers == null)
          {
              return NotFound();
          }
            var urunler = await _context.Urunlers.FindAsync(id);

            if (urunler == null)
            {
                return NotFound();
            }

            return urunler;
        }

        // PUT: api/Urunlers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUrunler(int id, Urunler urunler)
        {
            if (id != urunler.UrunId)
            {
                return BadRequest();
            }

            _context.Entry(urunler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UrunlerExists(id))
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

        // POST: api/Urunlers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Urunler>> PostUrunler(Urunler urunler)
        {
          if (_context.Urunlers == null)
          {
              return Problem("Entity set 'ModelContext.Urunlers'  is null.");
          }
            _context.Urunlers.Add(urunler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUrunler", new { id = urunler.UrunId }, urunler);
        }

        // DELETE: api/Urunlers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUrunler(int id)
        {
            if (_context.Urunlers == null)
            {
                return NotFound();
            }
            var urunler = await _context.Urunlers.FindAsync(id);
            if (urunler == null)
            {
                return NotFound();
            }

            _context.Urunlers.Remove(urunler);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UrunlerExists(int id)
        {
            return (_context.Urunlers?.Any(e => e.UrunId == id)).GetValueOrDefault();
        }
    }
}

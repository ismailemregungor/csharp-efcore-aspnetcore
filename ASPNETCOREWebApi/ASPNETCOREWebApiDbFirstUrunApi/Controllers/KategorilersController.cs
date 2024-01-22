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
    public class KategorilersController : ControllerBase
    {
        private readonly ModelContext _context;

        public KategorilersController(ModelContext context)
        {
            _context = context;
        }

        // GET: api/Kategorilers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kategoriler>>> GetKategorilers()
        {
          if (_context.Kategorilers == null)
          {
              return NotFound();
          }
            return await _context.Kategorilers.ToListAsync();
        }

        // GET: api/Kategorilers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kategoriler>> GetKategoriler(int id)
        {
          if (_context.Kategorilers == null)
          {
              return NotFound();
          }
            var kategoriler = await _context.Kategorilers.FindAsync(id);

            if (kategoriler == null)
            {
                return NotFound();
            }

            return kategoriler;
        }

        // PUT: api/Kategorilers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKategoriler(int id, Kategoriler kategoriler)
        {
            if (id != kategoriler.KategoriId)
            {
                return BadRequest();
            }

            _context.Entry(kategoriler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KategorilerExists(id))
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

        // POST: api/Kategorilers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Kategoriler>> PostKategoriler(Kategoriler kategoriler)
        {
          if (_context.Kategorilers == null)
          {
              return Problem("Entity set 'ModelContext.Kategorilers'  is null.");
          }
            _context.Kategorilers.Add(kategoriler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKategoriler", new { id = kategoriler.KategoriId }, kategoriler);
        }

        // DELETE: api/Kategorilers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKategoriler(int id)
        {
            if (_context.Kategorilers == null)
            {
                return NotFound();
            }
            var kategoriler = await _context.Kategorilers.FindAsync(id);
            if (kategoriler == null)
            {
                return NotFound();
            }

            _context.Kategorilers.Remove(kategoriler);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KategorilerExists(int id)
        {
            return (_context.Kategorilers?.Any(e => e.KategoriId == id)).GetValueOrDefault();
        }
    }
}

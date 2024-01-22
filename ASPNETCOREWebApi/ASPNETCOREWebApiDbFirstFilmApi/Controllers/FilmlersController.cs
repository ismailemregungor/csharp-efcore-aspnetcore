using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNETCOREWebApiDbFirstFilmApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASPNETCOREWebApiDbFirstFilmApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FilmlersController : ControllerBase
    {
        private readonly ModelContext _context;

        public FilmlersController(ModelContext context)
        {
            _context = context;
        }

        // GET: api/Filmlers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Filmler>>> GetFilmlers()
        {
          if (_context.Filmlers == null)
          {
              return NotFound();
          }
            return await _context.Filmlers.ToListAsync();
        }

        // GET: api/Filmlers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Filmler>> GetFilmler(int id)
        {
          if (_context.Filmlers == null)
          {
              return NotFound();
          }
            var filmler = await _context.Filmlers.FindAsync(id);

            if (filmler == null)
            {
                return NotFound();
            }

            return filmler;
        }

        // PUT: api/Filmlers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFilmler(int id, Filmler filmler)
        {
            if (id != filmler.FilmId)
            {
                return BadRequest();
            }

            _context.Entry(filmler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmlerExists(id))
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

        // POST: api/Filmlers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Filmler>> PostFilmler(Filmler filmler)
        {
          if (_context.Filmlers == null)
          {
              return Problem("Entity set 'ModelContext.Filmlers'  is null.");
          }
            _context.Filmlers.Add(filmler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFilmler", new { id = filmler.FilmId }, filmler);
        }

        // DELETE: api/Filmlers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFilmler(int id)
        {
            if (_context.Filmlers == null)
            {
                return NotFound();
            }
            var filmler = await _context.Filmlers.FindAsync(id);
            if (filmler == null)
            {
                return NotFound();
            }

            _context.Filmlers.Remove(filmler);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FilmlerExists(int id)
        {
            return (_context.Filmlers?.Any(e => e.FilmId == id)).GetValueOrDefault();
        }

        [AllowAnonymous]
        [HttpGet("Test")]
        public IActionResult Test()
        {
            return Ok("AllowAnonymous: herkes ulaşabilir");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Cars_Back.Models;

namespace Cars_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocatairesController : ControllerBase
    {
        private readonly LocataireDbContext _context;

        public LocatairesController(LocataireDbContext context)
        {
            _context = context;
        }

        // GET: api/Locataires
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Locataire>>> GetLocataires()
        {
            return await _context.Locataires.ToListAsync();
        }

        // GET: api/Locataires/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Locataire>> GetLocataire(int id)
        {
            var locataire = await _context.Locataires.FindAsync(id);

            if (locataire == null)
            {
                return NotFound();
            }

            return locataire;
        }

        // PUT: api/Locataires/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocataire(int id, Locataire locataire)
        {
            locataire.Id = id;

            _context.Entry(locataire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocataireExists(id))
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

        // POST: api/Locataires
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Locataire>> PostLocataire(Locataire locataire)
        {
            _context.Locataires.Add(locataire);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocataire", new { id = locataire.Id }, locataire);
        }

        // DELETE: api/Locataires/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocataire(int id)
        {
            var locataire = await _context.Locataires.FindAsync(id);
            if (locataire == null)
            {
                return NotFound();
            }

            _context.Locataires.Remove(locataire);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocataireExists(int id)
        {
            return _context.Locataires.Any(e => e.Id == id);
        }
    }
}

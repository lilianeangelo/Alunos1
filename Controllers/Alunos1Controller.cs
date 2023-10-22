using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Alunos1;

namespace Alunos1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Alunos1Controller : ControllerBase
    {
        private readonly DbContext _context;

        public Alunos1Controller(DbContext context)
        {
            _context = context;
        }

        // GET: api/Alunos1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alunos1>>> GetAlunos1()
        {
          if (_context.Alunos1 == null)
          {
              return NotFound();
          }
            return await _context.Alunos1.ToListAsync();
        }

        // GET: api/Alunos1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alunos1>> GetAlunos1(int id)
        {
          if (_context.Alunos1 == null)
          {
              return NotFound();
          }
            var alunos1 = await _context.Alunos1.FindAsync(id);

            if (alunos1 == null)
            {
                return NotFound();
            }

            return alunos1;
        }

        // PUT: api/Alunos1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlunos1(int id, Alunos1 alunos1)
        {
            if (id != alunos1.Id)
            {
                return BadRequest();
            }

            _context.Entry(alunos1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Alunos1Exists(id))
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

        // POST: api/Alunos1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Alunos1>> PostAlunos1(Alunos1 alunos1)
        {
          if (_context.Alunos1 == null)
          {
              return Problem("Entity set 'DbContext.Alunos1'  is null.");
          }
            _context.Alunos1.Add(alunos1);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlunos1", new { id = alunos1.Id }, alunos1);
        }

        // DELETE: api/Alunos1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlunos1(int id)
        {
            if (_context.Alunos1 == null)
            {
                return NotFound();
            }
            var alunos1 = await _context.Alunos1.FindAsync(id);
            if (alunos1 == null)
            {
                return NotFound();
            }

            _context.Alunos1.Remove(alunos1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Alunos1Exists(int id)
        {
            return (_context.Alunos1?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

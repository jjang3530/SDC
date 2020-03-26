using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDC_API.Models;

namespace SDC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class DraperiesController : ControllerBase
    {
        private readonly SDCContext _context;

        public DraperiesController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/Draperies
        [HttpGet]
        public IEnumerable<Drapery> GetDrapery()
        {
            return _context.Drapery;
        }

        // GET: api/Draperies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDrapery([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var drapery = await _context.Drapery.FindAsync(id);

            if (drapery == null)
            {
                return NotFound();
            }

            return Ok(drapery);
        }

        // PUT: api/Draperies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrapery([FromRoute] int id, [FromBody] Drapery drapery)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != drapery.ProjectId)
            {
                return BadRequest();
            }

            _context.Entry(drapery).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DraperyExists(id))
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

        // POST: api/Draperies
        [HttpPost]
        public async Task<IActionResult> PostDrapery([FromBody] Drapery drapery)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Drapery.Add(drapery);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DraperyExists(drapery.ProjectId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDrapery", new { id = drapery.ProjectId }, drapery);
        }

        // DELETE: api/Draperies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrapery([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var drapery = await _context.Drapery.FindAsync(id);
            if (drapery == null)
            {
                return NotFound();
            }

            _context.Drapery.Remove(drapery);
            await _context.SaveChangesAsync();

            return Ok(drapery);
        }

        private bool DraperyExists(int id)
        {
            return _context.Drapery.Any(e => e.ProjectId == id);
        }
    }
}
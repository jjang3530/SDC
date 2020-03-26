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
    public class CodeCategoriesController : ControllerBase
    {
        private readonly SDCContext _context;

        public CodeCategoriesController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/CodeCategories
        [HttpGet]
        public IEnumerable<CodeCategory> GetCodeCategory()
        {
            return _context.CodeCategory;
        }

        // GET: api/CodeCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCodeCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var codeCategory = await _context.CodeCategory.FindAsync(id);

            if (codeCategory == null)
            {
                return NotFound();
            }

            return Ok(codeCategory);
        }

        // PUT: api/CodeCategories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCodeCategory([FromRoute] int id, [FromBody] CodeCategory codeCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != codeCategory.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(codeCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodeCategoryExists(id))
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

        // POST: api/CodeCategories
        [HttpPost]
        public async Task<IActionResult> PostCodeCategory([FromBody] CodeCategory codeCategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CodeCategory.Add(codeCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCodeCategory", new { id = codeCategory.CategoryId }, codeCategory);
        }

        // DELETE: api/CodeCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCodeCategory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var codeCategory = await _context.CodeCategory.FindAsync(id);
            if (codeCategory == null)
            {
                return NotFound();
            }

            _context.CodeCategory.Remove(codeCategory);
            await _context.SaveChangesAsync();

            return Ok(codeCategory);
        }

        private bool CodeCategoryExists(int id)
        {
            return _context.CodeCategory.Any(e => e.CategoryId == id);
        }
    }
}
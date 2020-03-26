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
    public class CodeListsController : ControllerBase
    {
        private readonly SDCContext _context;

        public CodeListsController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/CodeLists
        [HttpGet]
        public IEnumerable<CodeList> GetCodeList()
        {
            return _context.CodeList;
        }

        // GET: api/CodeLists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCodeList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var codeList = await _context.CodeList.FindAsync(id);

            if (codeList == null)
            {
                return NotFound();
            }

            return Ok(codeList);
        }

        // PUT: api/CodeLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCodeList([FromRoute] int id, [FromBody] CodeList codeList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != codeList.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(codeList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CodeListExists(id))
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

        // POST: api/CodeLists
        [HttpPost]
        public async Task<IActionResult> PostCodeList([FromBody] CodeList codeList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CodeList.Add(codeList);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CodeListExists(codeList.CategoryId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCodeList", new { id = codeList.CategoryId }, codeList);
        }

        // DELETE: api/CodeLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCodeList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var codeList = await _context.CodeList.FindAsync(id);
            if (codeList == null)
            {
                return NotFound();
            }

            _context.CodeList.Remove(codeList);
            await _context.SaveChangesAsync();

            return Ok(codeList);
        }

        private bool CodeListExists(int id)
        {
            return _context.CodeList.Any(e => e.CategoryId == id);
        }
    }
}
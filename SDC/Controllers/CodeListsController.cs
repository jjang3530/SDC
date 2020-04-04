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

        // GET: api/CodeLists/1/codeid/2
        [HttpGet("{categoryId:int}/codeId/{codeId:int}")]
        public async Task<IActionResult> GetCodeList([FromRoute] int categoryId, int codeId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var codeList = await _context.CodeList.FirstOrDefaultAsync(s => s.CategoryId == categoryId && s.CodeId == codeId);

            if (codeList == null)
            {
                return NotFound();
            }

            return Ok(codeList);
        }

        // PUT: api/CodeLists/1/codeid/2
        [HttpPut("{categoryId:int}/codeId/{codeId:int}")]
        public async Task<IActionResult> PutCodeList([FromRoute] int categoryId, int codeId, [FromBody] CodeList codeList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (codeId != codeList.CodeId)
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
                if (!CategoryListExists(categoryId) && !CodeListExists(codeId))
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
                if (CategoryListExists(codeList.CategoryId) && CodeListExists(codeList.CodeId))
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

        // DELETE: api/CodeLists/1/codeid/2
        [HttpDelete("{categoryId:int}/codeId/{codeId:int}")]
        public async Task<IActionResult> DeleteCodeList([FromRoute] int categoryId, int codeId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var codeList = await _context.CodeList.FirstOrDefaultAsync(s => s.CategoryId == categoryId && s.CodeId == codeId);
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
            return _context.CodeList.Any(e => e.CodeId == id);
        }

        private bool CategoryListExists(int id)
        {
            return _context.CodeList.Any(e => e.CategoryId == id);
        }
    }
}
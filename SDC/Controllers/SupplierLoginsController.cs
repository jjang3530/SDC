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
    public class SupplierLoginsController : ControllerBase
    {
        private readonly SDCContext _context;

        public SupplierLoginsController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/SupplierLogins
        [HttpGet]
        public IEnumerable<SupplierLogin> GetSupplierLogin()
        {
            return _context.SupplierLogin;
        }

        // GET: api/SupplierLogins/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplierLogin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplierLogin = await _context.SupplierLogin.FindAsync(id);

            if (supplierLogin == null)
            {
                return NotFound();
            }

            return Ok(supplierLogin);
        }

        // PUT: api/SupplierLogins/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplierLogin([FromRoute] int id, [FromBody] SupplierLogin supplierLogin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != supplierLogin.SupplierId)
            {
                return BadRequest();
            }

            _context.Entry(supplierLogin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierLoginExists(id))
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

        // POST: api/SupplierLogins
        [HttpPost]
        public async Task<IActionResult> PostSupplierLogin([FromBody] SupplierLogin supplierLogin)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SupplierLogin.Add(supplierLogin);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupplierLoginExists(supplierLogin.SupplierId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupplierLogin", new { id = supplierLogin.SupplierId }, supplierLogin);
        }

        // DELETE: api/SupplierLogins/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierLogin([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplierLogin = await _context.SupplierLogin.FindAsync(id);
            if (supplierLogin == null)
            {
                return NotFound();
            }

            _context.SupplierLogin.Remove(supplierLogin);
            await _context.SaveChangesAsync();

            return Ok(supplierLogin);
        }

        private bool SupplierLoginExists(int id)
        {
            return _context.SupplierLogin.Any(e => e.SupplierId == id);
        }
    }
}
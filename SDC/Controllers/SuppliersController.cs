using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDC_API.Models;

namespace SDC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly SDCContext _context;

        public SuppliersController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/Suppliers
        [HttpGet]
        public IEnumerable<Supplier> GetSupplier()
        {
            return _context.Supplier;
        }

        // GET: api/Suppliers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplier([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplier = await _context.Supplier.FindAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return Ok(supplier);
        }

        // PUT: api/Suppliers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier([FromRoute] int id, [FromBody] Supplier supplier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != supplier.SupplierId)
            {
                return BadRequest();
            }

            _context.Entry(supplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierExists(id))
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

        // POST: api/Suppliers
        [HttpPost]
        public async Task<IActionResult> PostSupplier([FromBody] Supplier supplier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Supplier.Add(supplier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplier", new { id = supplier.SupplierId }, supplier);
        }

        // DELETE: api/Suppliers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplier = await _context.Supplier.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }

            _context.Supplier.Remove(supplier);
            await _context.SaveChangesAsync();

            return Ok(supplier);
        }

        private bool SupplierExists(int id)
        {
            return _context.Supplier.Any(e => e.SupplierId == id);
        }
    }
}
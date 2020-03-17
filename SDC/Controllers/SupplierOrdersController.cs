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
    public class SupplierOrdersController : ControllerBase
    {
        private readonly SDCContext _context;

        public SupplierOrdersController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/SupplierOrders
        [HttpGet]
        public IEnumerable<SupplierOrder> GetSupplierOrder()
        {
            return _context.SupplierOrder;
        }

        // GET: api/SupplierOrders/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplierOrder([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplierOrder = await _context.SupplierOrder.FindAsync(id);

            if (supplierOrder == null)
            {
                return NotFound();
            }

            return Ok(supplierOrder);
        }

        // PUT: api/SupplierOrders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplierOrder([FromRoute] int id, [FromBody] SupplierOrder supplierOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != supplierOrder.SupplierId)
            {
                return BadRequest();
            }

            _context.Entry(supplierOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierOrderExists(id))
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

        // POST: api/SupplierOrders
        [HttpPost]
        public async Task<IActionResult> PostSupplierOrder([FromBody] SupplierOrder supplierOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SupplierOrder.Add(supplierOrder);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupplierOrderExists(supplierOrder.SupplierId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupplierOrder", new { id = supplierOrder.SupplierId }, supplierOrder);
        }

        // DELETE: api/SupplierOrders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplierOrder([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var supplierOrder = await _context.SupplierOrder.FindAsync(id);
            if (supplierOrder == null)
            {
                return NotFound();
            }

            _context.SupplierOrder.Remove(supplierOrder);
            await _context.SaveChangesAsync();

            return Ok(supplierOrder);
        }

        private bool SupplierOrderExists(int id)
        {
            return _context.SupplierOrder.Any(e => e.SupplierId == id);
        }
    }
}
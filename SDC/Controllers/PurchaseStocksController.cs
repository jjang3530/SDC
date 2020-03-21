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
    public class PurchaseStocksController : ControllerBase
    {
        private readonly SDCContext _context;

        public PurchaseStocksController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseStocks
        [HttpGet]
        public IEnumerable<PurchaseStock> GetPurchaseStock()
        {
            return _context.PurchaseStock;
        }

        // GET: api/PurchaseStocks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPurchaseStock([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseStock = await _context.PurchaseStock.FindAsync(id);

            if (purchaseStock == null)
            {
                return NotFound();
            }

            return Ok(purchaseStock);
        }

        // PUT: api/PurchaseStocks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseStock([FromRoute] int id, [FromBody] PurchaseStock purchaseStock)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != purchaseStock.ProjectId)
            {
                return BadRequest();
            }

            _context.Entry(purchaseStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseStockExists(id))
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

        // POST: api/PurchaseStocks
        [HttpPost]
        public async Task<IActionResult> PostPurchaseStock([FromBody] PurchaseStock purchaseStock)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PurchaseStock.Add(purchaseStock);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PurchaseStockExists(purchaseStock.ProjectId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPurchaseStock", new { id = purchaseStock.ProjectId }, purchaseStock);
        }

        // DELETE: api/PurchaseStocks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseStock([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseStock = await _context.PurchaseStock.FindAsync(id);
            if (purchaseStock == null)
            {
                return NotFound();
            }

            _context.PurchaseStock.Remove(purchaseStock);
            await _context.SaveChangesAsync();

            return Ok(purchaseStock);
        }

        private bool PurchaseStockExists(int id)
        {
            return _context.PurchaseStock.Any(e => e.ProjectId == id);
        }
    }
}
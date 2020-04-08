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
        [HttpGet("{projectId:int}/odrerId/{orderId:int}/productId/{productId}")]
        public async Task<IActionResult> GetPurchaseStock([FromRoute] int projectId, int orderId, string productId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseStock = await _context.PurchaseStock.FirstOrDefaultAsync(s => s.ProjectId == projectId && s.OrderId == orderId && s.ProductId == productId);

            if (purchaseStock == null)
            {
                return NotFound();
            }

            return Ok(purchaseStock);
        }

        // PUT: api/PurchaseStocks/5
        [HttpPut("{projectId:int}/odrerId/{orderId:int}/productId/{productId}")]
        public async Task<IActionResult> PutPurchaseStock([FromRoute] int projectId, int orderId, string productId, [FromBody] PurchaseStock purchaseStock)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (projectId != purchaseStock.ProjectId)
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
                if (!ProjectExists(projectId) && !OrderExists(orderId) && !ProductExists(productId))
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
                if (ProjectExists(purchaseStock.ProjectId))
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
        [HttpDelete("{projectId:int}/odrerId/{orderId:int}/productId/{productId}")]
        public async Task<IActionResult> DeletePurchaseStock([FromRoute] int projectId, int orderId, string productId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseStock = await _context.PurchaseStock.FirstOrDefaultAsync(s => s.ProjectId == projectId && s.OrderId == orderId && s.ProductId == productId);
            if (purchaseStock == null)
            {
                return NotFound();
            }

            _context.PurchaseStock.Remove(purchaseStock);
            await _context.SaveChangesAsync();

            return Ok(purchaseStock);
        }

        private bool ProjectExists(int id)
        {
            return _context.PurchaseOrderdetail.Any(e => e.ProjectId == id);
        }

        private bool OrderExists(int id)
        {
            return _context.PurchaseOrderdetail.Any(e => e.OrderId == id);
        }

        private bool ProductExists(string id)
        {
            return _context.PurchaseOrderdetail.Any(e => e.ProductId == id);
        }
    }
}
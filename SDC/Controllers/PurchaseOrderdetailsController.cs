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
    public class PurchaseOrderdetailsController : ControllerBase
    {
        private readonly SDCContext _context;

        public PurchaseOrderdetailsController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrderdetails
        [HttpGet]
        public IEnumerable<PurchaseOrderdetail> GetPurchaseOrderdetail()
        {
            return _context.PurchaseOrderdetail;
        }

        // GET: api/PurchaseOrderdetails/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPurchaseOrderdetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseOrderdetail = await _context.PurchaseOrderdetail.FindAsync(id);

            if (purchaseOrderdetail == null)
            {
                return NotFound();
            }

            return Ok(purchaseOrderdetail);
        }

        // PUT: api/PurchaseOrderdetails/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPurchaseOrderdetail([FromRoute] int id, [FromBody] PurchaseOrderdetail purchaseOrderdetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != purchaseOrderdetail.ProjectId)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrderdetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PurchaseOrderdetailExists(id))
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

        // POST: api/PurchaseOrderdetails
        [HttpPost]
        public async Task<IActionResult> PostPurchaseOrderdetail([FromBody] PurchaseOrderdetail purchaseOrderdetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PurchaseOrderdetail.Add(purchaseOrderdetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PurchaseOrderdetailExists(purchaseOrderdetail.ProjectId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPurchaseOrderdetail", new { id = purchaseOrderdetail.ProjectId }, purchaseOrderdetail);
        }

        // DELETE: api/PurchaseOrderdetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePurchaseOrderdetail([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseOrderdetail = await _context.PurchaseOrderdetail.FindAsync(id);
            if (purchaseOrderdetail == null)
            {
                return NotFound();
            }

            _context.PurchaseOrderdetail.Remove(purchaseOrderdetail);
            await _context.SaveChangesAsync();

            return Ok(purchaseOrderdetail);
        }

        private bool PurchaseOrderdetailExists(int id)
        {
            return _context.PurchaseOrderdetail.Any(e => e.ProjectId == id);
        }
    }
}
﻿using System;
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
    public class PurchaseOrdersController : ControllerBase
    {
        private readonly SDCContext _context;

        public PurchaseOrdersController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/PurchaseOrders
        [HttpGet]
        public IEnumerable<PurchaseOrder> GetPurchaseOrder()
        {
            return _context.PurchaseOrder;
        }

        // GET: api/PurchaseOrders/5
        [HttpGet("{projectId:int}/orderid/{orderid:int}")]
        public async Task<IActionResult> GetPurchaseOrder([FromRoute] int projectId, int orderId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseOrder = await _context.PurchaseOrder.FirstOrDefaultAsync(s => s.ProjectId == projectId && s.OrderId == orderId);

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return Ok(purchaseOrder);
        }

        // PUT: api/PurchaseOrders/5
        [HttpPut("{projectId:int}/orderid/{orderid:int}")]
        public async Task<IActionResult> PutPurchaseOrder([FromRoute] int projectId, int orderId, [FromBody] PurchaseOrder purchaseOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (projectId != purchaseOrder.ProjectId)
            {
                return BadRequest();
            }

            _context.Entry(purchaseOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(projectId) && !OrderExists(orderId))
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

        // POST: api/PurchaseOrders
        [HttpPost]
        public async Task<IActionResult> PostPurchaseOrder([FromBody] PurchaseOrder purchaseOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PurchaseOrder.Add(purchaseOrder);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProjectExists(purchaseOrder.ProjectId) && OrderExists(purchaseOrder.OrderId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPurchaseOrder", new { id = purchaseOrder.ProjectId }, purchaseOrder);
        }

        // DELETE: api/PurchaseOrders/5
        [HttpDelete("{projectId:int}/orderid/{orderid:int}")]
        public async Task<IActionResult> DeletePurchaseOrder([FromRoute] int projectId, int orderId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var purchaseOrder = await _context.PurchaseOrder.FirstOrDefaultAsync(s => s.ProjectId == projectId && s.OrderId == orderId);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            _context.PurchaseOrder.Remove(purchaseOrder);
            await _context.SaveChangesAsync();

            return Ok(purchaseOrder);
        }

        private bool ProjectExists(int id)
        {
            return _context.PurchaseOrder.Any(e => e.ProjectId == id);
        }

        private bool OrderExists(int id)
        {
            return _context.PurchaseOrder.Any(e => e.OrderId == id);
        }
    }
}
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
    public class ItemsController : ControllerBase
    {
        private readonly SDCContext _context;

        public ItemsController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/Items
        [HttpGet]
        public IEnumerable<Items> GetItems()
        {
            return _context.Items;
        }

        // GET: api/Items/5
        [HttpGet("{projectId:int}/roomId/{roomId}/productId/{productId}")]
        public async Task<IActionResult> GetItems([FromRoute] int projectId, string roomId, string productId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = await _context.Items.FirstOrDefaultAsync(s => s.ProjectId == projectId && s.RoomId == roomId && s.ProductId == productId);

            if (items == null)
            {
                return NotFound();
            }

            return Ok(items);
        }

        // PUT: api/Items/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItems([FromRoute] int projectId, string roomId, string productId, [FromBody] Items items)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (projectId != items.ProjectId)
            {
                return BadRequest();
            }

            _context.Entry(items).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(projectId) && !RoomExists(roomId) && !ProductExists(productId))
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

        // POST: api/Items
        [HttpPost]
        public async Task<IActionResult> PostItems([FromBody] Items items)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Items.Add(items);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProjectExists(items.ProjectId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetItems", new { id = items.ProjectId }, items);
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItems([FromRoute] int projectId, string roomId, string productId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var items = await _context.Items.FirstOrDefaultAsync(s => s.ProjectId == projectId && s.RoomId == roomId && s.ProductId == productId);
            if (items == null)
            {
                return NotFound();
            }

            _context.Items.Remove(items);
            await _context.SaveChangesAsync();

            return Ok(items);
        }

        private bool ProjectExists(int id)
        {
            return _context.Items.Any(e => e.ProjectId == id);
        }

        private bool RoomExists(string id)
        {
            return _context.Items.Any(e => e.RoomId == id);
        }

        private bool ProductExists(string id)
        {
            return _context.Items.Any(e => e.ProductId == id);
        }
    }
}
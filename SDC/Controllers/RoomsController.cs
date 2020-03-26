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
    public class RoomsController : ControllerBase
    {
        private readonly SDCContext _context;

        public RoomsController(SDCContext context)
        {
            _context = context;
        }

        // GET: api/Rooms
        [HttpGet]
        public IEnumerable<Room> GetRoom()
        {
            return _context.Room;
        }

        // GET: api/Rooms/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoom([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var room = await _context.Room.FindAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            return Ok(room);
        }

        // PUT: api/Rooms/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom([FromRoute] int id, [FromBody] Room room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != room.ProjectId)
            {
                return BadRequest();
            }

            _context.Entry(room).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
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

        // POST: api/Rooms
        [HttpPost]
        public async Task<IActionResult> PostRoom([FromBody] Room room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Room.Add(room);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (RoomExists(room.ProjectId))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetRoom", new { id = room.ProjectId }, room);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }

            _context.Room.Remove(room);
            await _context.SaveChangesAsync();

            return Ok(room);
        }

        private bool RoomExists(int id)
        {
            return _context.Room.Any(e => e.ProjectId == id);
        }
    }
}
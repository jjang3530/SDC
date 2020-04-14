using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SDC_Web.Models;

namespace SDC_Web.Controllers
{
    public class RoomsController : Controller
    {
        private readonly SDCContext _context;

        public RoomsController(SDCContext context)
        {
            _context = context;
        }

        // GET: Rooms
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.Room.Include(r => r.DesignedByNavigation).Include(r => r.Project).Include(r => r.UpdatedByNavigation);
            return View(await sDCContext.ToListAsync());
        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int? projectId, string roomId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .Include(r => r.DesignedByNavigation)
                .Include(r => r.Project)
                .Include(r => r.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.RoomId == roomId);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,RoomId,FloorCeiling,TotCeiling,BotFloor,LootObject,RootObject,InsideHorizontal,InsideVertical,OutsideHorizontal,OutsideVertical,TrimDepth,InsideDepth,Sill,Control,Notes,DesignedBy,CreatedTime,UpdatedBy,UpdatedTime")] Room room)
        {
            if (ModelState.IsValid)
            {
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", room.DesignedBy);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag", room.ProjectId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", room.UpdatedBy);
            return View(room);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? projectId, string roomId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var room = await _context.Room.FindAsync(projectId, roomId);
            if (room == null)
            {
                return NotFound();
            }
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", room.DesignedBy);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag", room.ProjectId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", room.UpdatedBy);
            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? projectId, string roomId, [Bind("ProjectId,RoomId,FloorCeiling,TotCeiling,BotFloor,LootObject,RootObject,InsideHorizontal,InsideVertical,OutsideHorizontal,OutsideVertical,TrimDepth,InsideDepth,Sill,Control,Notes,DesignedBy,CreatedTime,UpdatedBy,UpdatedTime")] Room room)
        {
            if (projectId != room.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.ProjectId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", room.DesignedBy);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag", room.ProjectId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", room.UpdatedBy);
            return View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int? projectId, string roomId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var room = await _context.Room
                .Include(r => r.DesignedByNavigation)
                .Include(r => r.Project)
                .Include(r => r.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.RoomId == roomId);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? projectId, string roomId)
        {
            var room = await _context.Room.FindAsync(projectId, roomId);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(int id)
        {
            return _context.Room.Any(e => e.ProjectId == id);
        }
    }
}

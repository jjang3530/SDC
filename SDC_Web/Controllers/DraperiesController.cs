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
    public class DraperiesController : Controller
    {
        private readonly SDCContext _context;

        public DraperiesController(SDCContext context)
        {
            _context = context;
        }

        // GET: Draperies
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.Drapery.Include(d => d.DesignedByNavigation).Include(d => d.Room).Include(d => d.UpdatedByNavigation);
            return View(await sDCContext.ToListAsync());
        }

        // GET: Draperies/Details/5
        public async Task<IActionResult> Details(int? projectId, string roomId, int? draperyId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var drapery = await _context.Drapery
                .Include(d => d.DesignedByNavigation)
                .Include(d => d.Room)
                .Include(d => d.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.RoomId ==roomId && m.DraperyId == draperyId);
            if (drapery == null)
            {
                return NotFound();
            }

            return View(drapery);
        }

        // GET: Draperies/Create
        public IActionResult Create()
        {
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            ViewData["ProjectId"] = new SelectList(_context.Room, "ProjectId", "ProjectId");
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            return View();
        }

        // POST: Draperies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,RoomId,DraperyId,TypeName,TypeValue,DesignedBy,CreatedTime,UpdatedBy,UpdatedTime")] Drapery drapery)
        {
            if (ModelState.IsValid)
            {
                _context.Add(drapery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", drapery.DesignedBy);
            ViewData["ProjectId"] = new SelectList(_context.Room, "ProjectId", "ProjectId", drapery.ProjectId);
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", drapery.UpdatedBy);
            return View(drapery);
        }

        // GET: Draperies/Edit/5
        public async Task<IActionResult> Edit(int? projectId, string roomId, int? draperyId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var drapery = await _context.Drapery.FindAsync(projectId, roomId, draperyId);
            if (drapery == null)
            {
                return NotFound();
            }
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", drapery.DesignedBy);
            ViewData["ProjectId"] = new SelectList(_context.Room, "ProjectId", "ProjectId", drapery.ProjectId);
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", drapery.UpdatedBy);
            return View(drapery);
        }

        // POST: Draperies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? projectId, string roomId, int? draperyId, [Bind("ProjectId,RoomId,DraperyId,TypeName,TypeValue,DesignedBy,CreatedTime,UpdatedBy,UpdatedTime")] Drapery drapery)
        {
            if (projectId != drapery.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(drapery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DraperyExists(drapery.ProjectId))
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
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", drapery.DesignedBy);
            ViewData["ProjectId"] = new SelectList(_context.Room, "ProjectId", "ProjectId", drapery.ProjectId);
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", drapery.UpdatedBy);
            return View(drapery);
        }

        // GET: Draperies/Delete/5
        public async Task<IActionResult> Delete(int? projectId, string roomId, int? draperyId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var drapery = await _context.Drapery
                .Include(d => d.DesignedByNavigation)
                .Include(d => d.Room)
                .Include(d => d.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.RoomId == roomId && m.DraperyId == draperyId);
            if (drapery == null)
            {
                return NotFound();
            }

            return View(drapery);
        }

        // POST: Draperies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? projectId, string roomId, int? draperyId)
        {
            var drapery = await _context.Drapery.FindAsync(projectId, roomId, draperyId);
            _context.Drapery.Remove(drapery);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DraperyExists(int id)
        {
            return _context.Drapery.Any(e => e.ProjectId == id);
        }
    }
}

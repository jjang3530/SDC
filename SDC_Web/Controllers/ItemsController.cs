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
    public class ItemsController : Controller
    {
        private readonly SDCContext _context;

        public ItemsController(SDCContext context)
        {
            _context = context;
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.Items.Include(i => i.DesignedByNavigation).Include(i => i.Room).Include(i => i.UpdatedByNavigation);
            return View(await sDCContext.ToListAsync());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? projectId, string roomId, string productId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var items = await _context.Items
                .Include(i => i.DesignedByNavigation)
                .Include(i => i.Room)
                .Include(i => i.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.RoomId == roomId && m.ProductId == productId);
            if (items == null)
            {
                return NotFound();
            }

            return View(items);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            ViewData["ProjectId"] = new SelectList(_context.Room, "ProjectId", "ProjectId");
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,RoomId,ProductId,Dimension,Description,SupplierId,Pattern,Colour,Quantity,Uom,UnitPrice,RetailPrice,Amount,RetailAmount,DesignedBy,CreatedTime,UpdatedBy,UpdatedTime")] Items items)
        {
            if (ModelState.IsValid)
            {
                _context.Add(items);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", items.DesignedBy);
            ViewData["ProjectId"] = new SelectList(_context.Room, "ProjectId", "ProjectId", items.ProjectId);
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", items.UpdatedBy);
            return View(items);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? projectId, string roomId, string productId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var items = await _context.Items.FindAsync(projectId, roomId, productId);
            if (items == null)
            {
                return NotFound();
            }
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", items.DesignedBy);
            ViewData["ProjectId"] = new SelectList(_context.Room, "ProjectId", "ProjectId", items.ProjectId);
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", items.UpdatedBy);
            return View(items);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? projectId, string roomId, string productId, [Bind("ProjectId,RoomId,ProductId,Dimension,Description,SupplierId,Pattern,Colour,Quantity,Uom,UnitPrice,RetailPrice,Amount,RetailAmount,DesignedBy,CreatedTime,UpdatedBy,UpdatedTime")] Items items)
        {
            if (projectId != items.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(items);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemsExists(items.ProjectId))
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
            ViewData["DesignedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", items.DesignedBy);
            ViewData["ProjectId"] = new SelectList(_context.Room, "ProjectId", "ProjectId", items.ProjectId);
            ViewData["RoomId"] = new SelectList(_context.Room, "RoomId", "RoomId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", items.UpdatedBy);
            return View(items);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? projectId, string roomId, string productId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var items = await _context.Items
                .Include(i => i.DesignedByNavigation)
                .Include(i => i.Room)
                .Include(i => i.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.RoomId == roomId && m.ProductId == productId);
            if (items == null)
            {
                return NotFound();
            }

            return View(items);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? projectId, string roomId, string productId)
        {
            var items = await _context.Items.FindAsync(projectId, roomId, productId);
            _context.Items.Remove(items);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemsExists(int id)
        {
            return _context.Items.Any(e => e.ProjectId == id);
        }
    }
}

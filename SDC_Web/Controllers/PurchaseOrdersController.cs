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
    public class PurchaseOrdersController : Controller
    {
        private readonly SDCContext _context;

        public PurchaseOrdersController(SDCContext context)
        {
            _context = context;
        }

        // GET: PurchaseOrders
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.PurchaseOrder.Include(p => p.OrderedByNavigation).Include(p => p.Project).Include(p => p.Supplier).Include(p => p.UpdatedByNavigation);
            return View(await sDCContext.ToListAsync());
        }

        // GET: PurchaseOrders/Details/5
        public async Task<IActionResult> Details(int? projectId, int? orderId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder
                .Include(p => p.OrderedByNavigation)
                .Include(p => p.Project)
                .Include(p => p.Supplier)
                .Include(p => p.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.OrderId == orderId);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Create
        public IActionResult Create()
        {
            ViewData["OrderedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag");
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            return View();
        }

        // POST: PurchaseOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,OrderId,SupplierId,ShippingPlace,ShippingAddress,ShippingPhone,EstimatedShipdate,OrderedBy,CreatedTime,UpdatedBy,UpdatedTime")] PurchaseOrder purchaseOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrder.OrderedBy);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag", purchaseOrder.ProjectId);
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company", purchaseOrder.SupplierId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrder.UpdatedBy);
            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Edit/5
        public async Task<IActionResult> Edit(int? projectId, int? orderId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder.FindAsync(projectId, orderId);
            if (purchaseOrder == null)
            {
                return NotFound();
            }
            ViewData["OrderedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrder.OrderedBy);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag", purchaseOrder.ProjectId);
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company", purchaseOrder.SupplierId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrder.UpdatedBy);
            return View(purchaseOrder);
        }

        // POST: PurchaseOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? projectId, int? orderId, [Bind("ProjectId,OrderId,SupplierId,ShippingPlace,ShippingAddress,ShippingPhone,EstimatedShipdate,OrderedBy,CreatedTime,UpdatedBy,UpdatedTime")] PurchaseOrder purchaseOrder)
        {
            if (projectId != purchaseOrder.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseOrderExists(purchaseOrder.ProjectId))
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
            ViewData["OrderedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrder.OrderedBy);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag", purchaseOrder.ProjectId);
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company", purchaseOrder.SupplierId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrder.UpdatedBy);
            return View(purchaseOrder);
        }

        // GET: PurchaseOrders/Delete/5
        public async Task<IActionResult> Delete(int? projectId, int? orderId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var purchaseOrder = await _context.PurchaseOrder
                .Include(p => p.OrderedByNavigation)
                .Include(p => p.Project)
                .Include(p => p.Supplier)
                .Include(p => p.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.OrderId == orderId);
            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return View(purchaseOrder);
        }

        // POST: PurchaseOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? projectId, int? orderId)
        {
            var purchaseOrder = await _context.PurchaseOrder.FindAsync(projectId, orderId);
            _context.PurchaseOrder.Remove(purchaseOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseOrderExists(int id)
        {
            return _context.PurchaseOrder.Any(e => e.ProjectId == id);
        }
    }
}

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
    public class PurchaseOrderdetailsController : Controller
    {
        private readonly SDCContext _context;

        public PurchaseOrderdetailsController(SDCContext context)
        {
            _context = context;
        }

        // GET: PurchaseOrderdetails
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.PurchaseOrderdetail.Include(p => p.OrderedByNavigation).Include(p => p.PurchaseOrder).Include(p => p.UpdatedByNavigation);
            return View(await sDCContext.ToListAsync());
        }

        // GET: PurchaseOrderdetails/Details/5
        public async Task<IActionResult> Details(int? projectId, int? orderId, string productId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var purchaseOrderdetail = await _context.PurchaseOrderdetail
                .Include(p => p.OrderedByNavigation)
                .Include(p => p.PurchaseOrder)
                .Include(p => p.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.OrderId == orderId && m.ProductId == productId);
            if (purchaseOrderdetail == null)
            {
                return NotFound();
            }

            return View(purchaseOrderdetail);
        }

        // GET: PurchaseOrderdetails/Create
        public IActionResult Create()
        {
            ViewData["OrderedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            ViewData["ProjectId"] = new SelectList(_context.PurchaseOrder, "ProjectId", "ProjectId");
            ViewData["OrderId"] = new SelectList(_context.PurchaseOrder, "OrderId", "OrderId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            return View();
        }

        // POST: PurchaseOrderdetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,OrderId,ProductId,Dimension,Description,Pattern,Colour,Quantity,Uom,UnitPrice,Amount,DeliveryStatus,OrderedBy,CreatedTime,UpdatedBy,UpdatedTime")] PurchaseOrderdetail purchaseOrderdetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseOrderdetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrderdetail.OrderedBy);
            ViewData["ProjectId"] = new SelectList(_context.PurchaseOrder, "ProjectId", "ProjectId", purchaseOrderdetail.ProjectId);
            ViewData["OrderId"] = new SelectList(_context.PurchaseOrder, "OrderId", "OrderId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrderdetail.UpdatedBy);
            return View(purchaseOrderdetail);
        }

        // GET: PurchaseOrderdetails/Edit/5
        public async Task<IActionResult> Edit(int? projectId, int? orderId, string productId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var purchaseOrderdetail = await _context.PurchaseOrderdetail.FindAsync(projectId, orderId, productId);
            if (purchaseOrderdetail == null)
            {
                return NotFound();
            }
            ViewData["OrderedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrderdetail.OrderedBy);
            ViewData["ProjectId"] = new SelectList(_context.PurchaseOrder, "ProjectId", "ProjectId", purchaseOrderdetail.ProjectId);
            ViewData["OrderId"] = new SelectList(_context.PurchaseOrder, "OrderId", "OrderId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrderdetail.UpdatedBy);
            return View(purchaseOrderdetail);
        }

        // POST: PurchaseOrderdetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? projectId, int? orderId, string productId, [Bind("ProjectId,OrderId,ProductId,Dimension,Description,Pattern,Colour,Quantity,Uom,UnitPrice,Amount,DeliveryStatus,OrderedBy,CreatedTime,UpdatedBy,UpdatedTime")] PurchaseOrderdetail purchaseOrderdetail)
        {
            if (projectId != purchaseOrderdetail.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseOrderdetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseOrderdetailExists(purchaseOrderdetail.ProjectId))
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
            ViewData["OrderedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrderdetail.OrderedBy);
            ViewData["ProjectId"] = new SelectList(_context.PurchaseOrder, "ProjectId", "ProjectId", purchaseOrderdetail.ProjectId);
            ViewData["OrderId"] = new SelectList(_context.PurchaseOrder, "OrderId", "OrderId");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseOrderdetail.UpdatedBy);
            return View(purchaseOrderdetail);
        }

        // GET: PurchaseOrderdetails/Delete/5
        public async Task<IActionResult> Delete(int? projectId, int? orderId, string productId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var purchaseOrderdetail = await _context.PurchaseOrderdetail
                .Include(p => p.OrderedByNavigation)
                .Include(p => p.PurchaseOrder)
                .Include(p => p.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.OrderId == orderId && m.ProductId == productId);
            if (purchaseOrderdetail == null)
            {
                return NotFound();
            }

            return View(purchaseOrderdetail);
        }

        // POST: PurchaseOrderdetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? projectId, int? orderId, string productId)
        {
            var purchaseOrderdetail = await _context.PurchaseOrderdetail.FindAsync(projectId, orderId, productId);
            _context.PurchaseOrderdetail.Remove(purchaseOrderdetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseOrderdetailExists(int id)
        {
            return _context.PurchaseOrderdetail.Any(e => e.ProjectId == id);
        }
    }
}

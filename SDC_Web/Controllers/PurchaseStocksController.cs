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
    public class PurchaseStocksController : Controller
    {
        private readonly SDCContext _context;

        public PurchaseStocksController(SDCContext context)
        {
            _context = context;
        }

        // GET: PurchaseStocks
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.PurchaseStock.Include(p => p.PurchaseOrderdetail).Include(p => p.ReceivedByNavigation).Include(p => p.UpdatedByNavigation);
            return View(await sDCContext.ToListAsync());
        }

        // GET: PurchaseStocks/Details/5
        public async Task<IActionResult> Details(int? projectId, int? orderId, string productId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var purchaseStock = await _context.PurchaseStock
                .Include(p => p.PurchaseOrderdetail)
                .Include(p => p.ReceivedByNavigation)
                .Include(p => p.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.OrderId == orderId && m.ProductId == productId);
            if (purchaseStock == null)
            {
                return NotFound();
            }

            return View(purchaseStock);
        }

        // GET: PurchaseStocks/Create
        public IActionResult Create()
        {
            ViewData["ProjectId"] = new SelectList(_context.PurchaseOrderdetail, "ProjectId", "ProductId");
            ViewData["OrderId"] = new SelectList(_context.PurchaseOrderdetail, "OrderId", "OrderId");
            ViewData["ProductId"] = new SelectList(_context.PurchaseOrderdetail, "ProductId", "ProductId");
            ViewData["ReceivedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            return View();
        }

        // POST: PurchaseStocks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,OrderId,ProductId,Dimension,Description,Pattern,Colour,Quantity,Uom,UnitPrice,Amount,ReceivedBy,CreatedTime,UpdatedBy,UpdatedTime")] PurchaseStock purchaseStock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchaseStock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectId"] = new SelectList(_context.PurchaseOrderdetail, "ProjectId", "ProductId", purchaseStock.ProjectId);
            ViewData["OrderId"] = new SelectList(_context.PurchaseOrderdetail, "OrderId", "OrderId", purchaseStock.OrderId);
            ViewData["ProductId"] = new SelectList(_context.PurchaseOrderdetail, "ProductId", "ProductId", purchaseStock.ProductId);
            ViewData["ReceivedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseStock.ReceivedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseStock.UpdatedBy);
            return View(purchaseStock);
        }

        // GET: PurchaseStocks/Edit/5
        public async Task<IActionResult> Edit(int? projectId, int? orderId, string productId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var purchaseStock = await _context.PurchaseStock.FindAsync(projectId, orderId, productId);
            if (purchaseStock == null)
            {
                return NotFound();
            }
            ViewData["ProjectId"] = new SelectList(_context.PurchaseOrderdetail, "ProjectId", "ProductId", purchaseStock.ProjectId);
            ViewData["OrderId"] = new SelectList(_context.PurchaseOrderdetail, "OrderId", "OrderId", purchaseStock.OrderId);
            ViewData["ProductId"] = new SelectList(_context.PurchaseOrderdetail, "ProductId", "ProductId", purchaseStock.ProductId);
            ViewData["ReceivedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseStock.ReceivedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseStock.UpdatedBy);
            return View(purchaseStock);
        }

        // POST: PurchaseStocks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? projectId, int? orderId, string productId, [Bind("ProjectId,OrderId,ProductId,Dimension,Description,Pattern,Colour,Quantity,Uom,UnitPrice,Amount,ReceivedBy,CreatedTime,UpdatedBy,UpdatedTime")] PurchaseStock purchaseStock)
        {
            if (projectId != purchaseStock.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchaseStock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchaseStockExists(purchaseStock.ProjectId))
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
            ViewData["ProjectId"] = new SelectList(_context.PurchaseOrderdetail, "ProjectId", "ProductId", purchaseStock.ProjectId);
            ViewData["OrderId"] = new SelectList(_context.PurchaseOrderdetail, "OrderId", "OrderId", purchaseStock.OrderId);
            ViewData["ProductId"] = new SelectList(_context.PurchaseOrderdetail, "ProductId", "ProductId", purchaseStock.ProductId);
            ViewData["ReceivedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseStock.ReceivedBy);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", purchaseStock.UpdatedBy);
            return View(purchaseStock);
        }

        // GET: PurchaseStocks/Delete/5
        public async Task<IActionResult> Delete(int? projectId, int? orderId, string productId)
        {
            if (projectId == null)
            {
                return NotFound();
            }

            var purchaseStock = await _context.PurchaseStock
                .Include(p => p.PurchaseOrderdetail)
                .Include(p => p.ReceivedByNavigation)
                .Include(p => p.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == projectId && m.OrderId == orderId && m.ProductId == productId);
            if (purchaseStock == null)
            {
                return NotFound();
            }

            return View(purchaseStock);
        }

        // POST: PurchaseStocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? projectId, int? orderId, string productId)
        {
            var purchaseStock = await _context.PurchaseStock.FindAsync(projectId, orderId, productId);
            _context.PurchaseStock.Remove(purchaseStock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchaseStockExists(int id)
        {
            return _context.PurchaseStock.Any(e => e.ProjectId == id);
        }
    }
}

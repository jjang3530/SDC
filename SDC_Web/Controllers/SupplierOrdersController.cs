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
    public class SupplierOrdersController : Controller
    {
        private readonly SDCContext _context;

        public SupplierOrdersController(SDCContext context)
        {
            _context = context;
        }

        // GET: SupplierOrders
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.SupplierOrder.Include(s => s.Supplier);
            return View(await sDCContext.ToListAsync());
        }

        // GET: SupplierOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierOrder = await _context.SupplierOrder
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (supplierOrder == null)
            {
                return NotFound();
            }

            return View(supplierOrder);
        }

        // GET: SupplierOrders/Create
        public IActionResult Create()
        {
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company");
            return View();
        }

        // POST: SupplierOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,OrderingMethod,OrderingEmail,PriceFound,DiscountOw,DiscountOr,DiscountNotes,Terms,LeadTime,SalesReq,Books,PaymentMethod,PaymentNotes")] SupplierOrder supplierOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company", supplierOrder.SupplierId);
            return View(supplierOrder);
        }

        // GET: SupplierOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierOrder = await _context.SupplierOrder.FindAsync(id);
            if (supplierOrder == null)
            {
                return NotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company", supplierOrder.SupplierId);
            return View(supplierOrder);
        }

        // POST: SupplierOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierId,OrderingMethod,OrderingEmail,PriceFound,DiscountOw,DiscountOr,DiscountNotes,Terms,LeadTime,SalesReq,Books,PaymentMethod,PaymentNotes")] SupplierOrder supplierOrder)
        {
            if (id != supplierOrder.SupplierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierOrderExists(supplierOrder.SupplierId))
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
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company", supplierOrder.SupplierId);
            return View(supplierOrder);
        }

        // GET: SupplierOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierOrder = await _context.SupplierOrder
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (supplierOrder == null)
            {
                return NotFound();
            }

            return View(supplierOrder);
        }

        // POST: SupplierOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplierOrder = await _context.SupplierOrder.FindAsync(id);
            _context.SupplierOrder.Remove(supplierOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierOrderExists(int id)
        {
            return _context.SupplierOrder.Any(e => e.SupplierId == id);
        }
    }
}

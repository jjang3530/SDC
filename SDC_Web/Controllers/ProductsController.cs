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
    public class ProductsController : Controller
    {
        private readonly SDCContext _context;

        public ProductsController(SDCContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.Product.Include(p => p.CreatedByNavigation);
            return View(await sDCContext.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? supplierId, string productId)
        {
            if (supplierId == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.CreatedByNavigation)
                .FirstOrDefaultAsync(m => m.SupplierId == supplierId && m.ProductId == productId);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CreatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,ProductId,Dimension,Description,Finishes,Uom,Price,BookNumber,CreatedBy,CreatedTime")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CreatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", product.CreatedBy);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? supplierId, string productId)
        {
            if (supplierId == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(supplierId, productId);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CreatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", product.CreatedBy);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int supplierId, [Bind("SupplierId,ProductId,Dimension,Description,Finishes,Uom,Price,BookNumber,CreatedBy,CreatedTime")] Product product)
        {
            if (supplierId != product.SupplierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.SupplierId))
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
            ViewData["CreatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", product.CreatedBy);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? supplierId, string productId)
        {
            if (supplierId == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.CreatedByNavigation)
                .FirstOrDefaultAsync(m => m.SupplierId == supplierId && m.ProductId == productId);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? supplierId, string productId)
        {
            var product = await _context.Product.FindAsync(supplierId, productId);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.SupplierId == id);
        }
    }
}

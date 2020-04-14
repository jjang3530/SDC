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
    public class SupplierLoginsController : Controller
    {
        private readonly SDCContext _context;

        public SupplierLoginsController(SDCContext context)
        {
            _context = context;
        }

        // GET: SupplierLogins
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.SupplierLogin.Include(s => s.Supplier);
            return View(await sDCContext.ToListAsync());
        }

        // GET: SupplierLogins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierLogin = await _context.SupplierLogin
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (supplierLogin == null)
            {
                return NotFound();
            }

            return View(supplierLogin);
        }

        // GET: SupplierLogins/Create
        public IActionResult Create()
        {
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company");
            return View();
        }

        // POST: SupplierLogins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupplierId,Website,Login,Password,Notes")] SupplierLogin supplierLogin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supplierLogin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company", supplierLogin.SupplierId);
            return View(supplierLogin);
        }

        // GET: SupplierLogins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierLogin = await _context.SupplierLogin.FindAsync(id);
            if (supplierLogin == null)
            {
                return NotFound();
            }
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company", supplierLogin.SupplierId);
            return View(supplierLogin);
        }

        // POST: SupplierLogins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupplierId,Website,Login,Password,Notes")] SupplierLogin supplierLogin)
        {
            if (id != supplierLogin.SupplierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supplierLogin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupplierLoginExists(supplierLogin.SupplierId))
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
            ViewData["SupplierId"] = new SelectList(_context.Supplier, "SupplierId", "Company", supplierLogin.SupplierId);
            return View(supplierLogin);
        }

        // GET: SupplierLogins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supplierLogin = await _context.SupplierLogin
                .Include(s => s.Supplier)
                .FirstOrDefaultAsync(m => m.SupplierId == id);
            if (supplierLogin == null)
            {
                return NotFound();
            }

            return View(supplierLogin);
        }

        // POST: SupplierLogins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supplierLogin = await _context.SupplierLogin.FindAsync(id);
            _context.SupplierLogin.Remove(supplierLogin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupplierLoginExists(int id)
        {
            return _context.SupplierLogin.Any(e => e.SupplierId == id);
        }
    }
}

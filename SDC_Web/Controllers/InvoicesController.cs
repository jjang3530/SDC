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
    public class InvoicesController : Controller
    {
        private readonly SDCContext _context;

        public InvoicesController(SDCContext context)
        {
            _context = context;
        }

        // GET: Invoices
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.Invoice.Include(i => i.InvoiceByNavigation).Include(i => i.Project).Include(i => i.UpdatedByNavigation);
            return View(await sDCContext.ToListAsync());
        }

        // GET: Invoices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoice
                .Include(i => i.InvoiceByNavigation)
                .Include(i => i.Project)
                .Include(i => i.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // GET: Invoices/Create
        public IActionResult Create()
        {
            ViewData["InvoiceBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag");
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName");
            return View();
        }

        // POST: Invoices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,InvoiceDate,Terms,BillPlace,BillAddress,BillPhone,BillEmail,ShipPlace,ShipAddress,Subtotal,Shipping,Hst,TotalAmount,InvoiceBy,CreatedTime,UpdatedBy,UpdatedTime")] Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvoiceBy"] = new SelectList(_context.Employee, "UserId", "FirstName", invoice.InvoiceBy);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag", invoice.ProjectId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", invoice.UpdatedBy);
            return View(invoice);
        }

        // GET: Invoices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoice.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }
            ViewData["InvoiceBy"] = new SelectList(_context.Employee, "UserId", "FirstName", invoice.InvoiceBy);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag", invoice.ProjectId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", invoice.UpdatedBy);
            return View(invoice);
        }

        // POST: Invoices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectId,InvoiceDate,Terms,BillPlace,BillAddress,BillPhone,BillEmail,ShipPlace,ShipAddress,Subtotal,Shipping,Hst,TotalAmount,InvoiceBy,CreatedTime,UpdatedBy,UpdatedTime")] Invoice invoice)
        {
            if (id != invoice.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceExists(invoice.ProjectId))
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
            ViewData["InvoiceBy"] = new SelectList(_context.Employee, "UserId", "FirstName", invoice.InvoiceBy);
            ViewData["ProjectId"] = new SelectList(_context.Project, "ProjectId", "ProjectTag", invoice.ProjectId);
            ViewData["UpdatedBy"] = new SelectList(_context.Employee, "UserId", "FirstName", invoice.UpdatedBy);
            return View(invoice);
        }

        // GET: Invoices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoice
                .Include(i => i.InvoiceByNavigation)
                .Include(i => i.Project)
                .Include(i => i.UpdatedByNavigation)
                .FirstOrDefaultAsync(m => m.ProjectId == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // POST: Invoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoice = await _context.Invoice.FindAsync(id);
            _context.Invoice.Remove(invoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceExists(int id)
        {
            return _context.Invoice.Any(e => e.ProjectId == id);
        }
    }
}

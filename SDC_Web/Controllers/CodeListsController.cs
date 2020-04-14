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
    public class CodeListsController : Controller
    {
        private readonly SDCContext _context;

        public CodeListsController(SDCContext context)
        {
            _context = context;
        }

        // GET: CodeLists
        public async Task<IActionResult> Index()
        {
            var sDCContext = _context.CodeList.Include(c => c.Category);
            return View(await sDCContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? categoryId, int? codeId)
        {
            if (categoryId == null)
            {
                return NotFound();
            }

            var codeList = await _context.CodeList
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.CategoryId == categoryId && m.CodeId == codeId);
            if (codeList == null)
            {
                return NotFound();
            }

            return View(codeList);
        }

        // GET: CodeLists/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.CodeCategory, "CategoryId", "CategoryName");
            return View();
        }

        // POST: CodeLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CodeId,CodeName")] CodeList codeList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(codeList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.CodeCategory, "CategoryId", "CategoryName", codeList.CategoryId);
            return View(codeList);
        }

        // GET: CodeLists/Edit/5
        public async Task<IActionResult> Edit(int? categoryId, int? codeId)
        {
            if (categoryId == null)
            {
                return NotFound();
            }

            var codeList = await _context.CodeList.FindAsync(categoryId, codeId);
            if (codeList == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.CodeCategory, "CategoryId", "CategoryName", codeList.CategoryId);
            return View(codeList);
        }

        // POST: CodeLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int categoryId, [Bind("CategoryId,CodeId,CodeName")] CodeList codeList)
        {
            if (categoryId != codeList.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(codeList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CodeListExists(codeList.CategoryId))
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
            ViewData["CategoryId"] = new SelectList(_context.CodeCategory, "CategoryId", "CategoryName", codeList.CategoryId);
            return View(codeList);
        }

        // GET: CodeLists/Delete/5
        public async Task<IActionResult> Delete(int? categoryId, int? codeId)
        {
            if (categoryId == null)
            {
                return NotFound();
            }

            var codeList = await _context.CodeList
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.CategoryId == categoryId && m.CodeId == codeId);
            if (codeList == null)
            {
                return NotFound();
            }

            return View(codeList);
        }

        // POST: CodeLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? categoryId, int? codeId)
        {
            var codeList = await _context.CodeList.FindAsync(categoryId, codeId);
            _context.CodeList.Remove(codeList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CodeListExists(int id)
        {
            return _context.CodeList.Any(e => e.CategoryId == id);
        }
    }
}

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
    public class CodeCategoriesController : Controller
    {
        private readonly SDCContext _context;

        public CodeCategoriesController(SDCContext context)
        {
            _context = context;
        }

        // GET: CodeCategories
        public async Task<IActionResult> Index()
        {
            return View(await _context.CodeCategory.ToListAsync());
        }

        // GET: CodeCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codeCategory = await _context.CodeCategory
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (codeCategory == null)
            {
                return NotFound();
            }

            return View(codeCategory);
        }

        // GET: CodeCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CodeCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategoryName")] CodeCategory codeCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(codeCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(codeCategory);
        }

        // GET: CodeCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codeCategory = await _context.CodeCategory.FindAsync(id);
            if (codeCategory == null)
            {
                return NotFound();
            }
            return View(codeCategory);
        }

        // POST: CodeCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,CategoryName")] CodeCategory codeCategory)
        {
            if (id != codeCategory.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(codeCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CodeCategoryExists(codeCategory.CategoryId))
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
            return View(codeCategory);
        }

        // GET: CodeCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var codeCategory = await _context.CodeCategory
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (codeCategory == null)
            {
                return NotFound();
            }

            return View(codeCategory);
        }

        // POST: CodeCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var codeCategory = await _context.CodeCategory.FindAsync(id);
            _context.CodeCategory.Remove(codeCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CodeCategoryExists(int id)
        {
            return _context.CodeCategory.Any(e => e.CategoryId == id);
        }
    }
}

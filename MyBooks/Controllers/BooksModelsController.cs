using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyBooks.Models;
using static MyBooks.Helper;

namespace MyBooks.Controllers
{
    public class BooksModelsController : Controller
    {
        private readonly BookDbContext _context;

        public BooksModelsController(BookDbContext context)
        {
            _context = context;
        }

        // GET: BooksModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Book.ToListAsync());
        }

        // GET: Transaction/AddOrEdit(Insert)
        // GET: Transaction/AddOrEdit/5(Update)
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new BooksModel());
            else
            {
                var booksModel = await _context.Book.FindAsync(id);
                if (booksModel == null)
                {
                    return NotFound();
                }
                return View(booksModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("bookId,nameBook,genreBook,authorBook,pagesBook,Date")] BooksModel booksModel)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    booksModel.Date = DateTime.Now;
                    _context.Add(booksModel);
                    await _context.SaveChangesAsync();

                }
                // Обнова
                else
                {
                    try
                    {
                        _context.Update(booksModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!BooksModelExists(booksModel.bookId))
                        {
                            return NotFound();
                        }
                        else
                        { throw; }
                    }
                }
                return Json(new { isValid = true, html = RenderRazorViewToString(this, "_ViewAll", _context.Book.ToList()) });
            }
            return Json(new { isValid = false, html = RenderRazorViewToString(this, "AddOrEdit", booksModel) });
        }
        
        // GET: BooksModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booksModel = await _context.Book
                .FirstOrDefaultAsync(m => m.bookId == id);
            if (booksModel == null)
            {
                return NotFound();
            }

            return View(booksModel);
        }

        // POST: BooksModels/Delete/5
        [HttpPost, ActionName("Видалити")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booksModel = await _context.Book.FindAsync(id);
            _context.Book.Remove(booksModel);
            await _context.SaveChangesAsync();
            return Json(new { html = RenderRazorViewToString(this, "_ViewAll", _context.Book.ToList()) });
        }

        private bool BooksModelExists(int id)
        {
            return _context.Book.Any(e => e.bookId == id);
        }
    }
}

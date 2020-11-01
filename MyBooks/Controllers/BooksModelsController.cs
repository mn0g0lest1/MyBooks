using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyBooks.Models;

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

        // GET: BooksModels/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: BooksModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BooksModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("bookId,nameBook,genreBook,authorBook,pagesBook,Date")] BooksModel booksModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booksModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(booksModel);
        }

        // GET: BooksModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booksModel = await _context.Book.FindAsync(id);
            if (booksModel == null)
            {
                return NotFound();
            }
            return View(booksModel);
        }

        // POST: BooksModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("bookId,nameBook,genreBook,authorBook,pagesBook,Date")] BooksModel booksModel)
        {
            if (id != booksModel.bookId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
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
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(booksModel);
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
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booksModel = await _context.Book.FindAsync(id);
            _context.Book.Remove(booksModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BooksModelExists(int id)
        {
            return _context.Book.Any(e => e.bookId == id);
        }
    }
}

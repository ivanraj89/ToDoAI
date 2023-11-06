using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToDoAI.Data;
using ToDoAI.Models;

namespace ToDoAI.Controllers
{
    public class InputFieldsController : Controller
    {
        private readonly ToDoAiAppDbContext _context;

        public InputFieldsController(ToDoAiAppDbContext context)
        {
            _context = context;
        }

        // GET: InputFields
        public async Task<IActionResult> Index()
        {
              return _context.InputFields != null ? 
                          View(await _context.InputFields.ToListAsync()) :
                          Problem("Entity set 'ToDoAiAppDbContext.InputFields'  is null.");
        }

        // GET: InputFields/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InputFields == null)
            {
                return NotFound();
            }

            var inputFields = await _context.InputFields
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inputFields == null)
            {
                return NotFound();
            }

            return View(inputFields);
        }

        // GET: InputFields/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InputFields/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ToDo,TypeOfHelp,DateTime")] InputFields inputFields)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inputFields);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inputFields);
        }

        // GET: InputFields/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InputFields == null)
            {
                return NotFound();
            }

            var inputFields = await _context.InputFields.FindAsync(id);
            if (inputFields == null)
            {
                return NotFound();
            }
            return View(inputFields);
        }

        // POST: InputFields/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ToDo,TypeOfHelp,DateTime")] InputFields inputFields)
        {
            if (id != inputFields.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inputFields);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InputFieldsExists(inputFields.Id))
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
            return View(inputFields);
        }

        // GET: InputFields/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InputFields == null)
            {
                return NotFound();
            }

            var inputFields = await _context.InputFields
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inputFields == null)
            {
                return NotFound();
            }

            return View(inputFields);
        }

        // POST: InputFields/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InputFields == null)
            {
                return Problem("Entity set 'ToDoAiAppDbContext.InputFields'  is null.");
            }
            var inputFields = await _context.InputFields.FindAsync(id);
            if (inputFields != null)
            {
                _context.InputFields.Remove(inputFields);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InputFieldsExists(int id)
        {
          return (_context.InputFields?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

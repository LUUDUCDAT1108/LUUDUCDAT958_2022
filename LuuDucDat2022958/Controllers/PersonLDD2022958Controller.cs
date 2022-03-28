#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LuuDucDat2022958.Data;
using LuuDucDat2022958.Models;

namespace LuuDucDat2022958.Controllers
{
    public class PersonLDD2022958Controller : Controller
    {
        private readonly LuuDucDat2022958Context _context;

        public PersonLDD2022958Controller(LuuDucDat2022958Context context)
        {
            _context = context;
        }

        // GET: PersonLDD2022958
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonLDD2022958.ToListAsync());
        }

        // GET: PersonLDD2022958/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLDD2022958 = await _context.PersonLDD2022958
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personLDD2022958 == null)
            {
                return NotFound();
            }

            return View(personLDD2022958);
        }

        // GET: PersonLDD2022958/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonLDD2022958/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonId,PersonName")] PersonLDD2022958 personLDD2022958)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personLDD2022958);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personLDD2022958);
        }

        // GET: PersonLDD2022958/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLDD2022958 = await _context.PersonLDD2022958.FindAsync(id);
            if (personLDD2022958 == null)
            {
                return NotFound();
            }
            return View(personLDD2022958);
        }

        // POST: PersonLDD2022958/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PersonId,PersonName")] PersonLDD2022958 personLDD2022958)
        {
            if (id != personLDD2022958.PersonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personLDD2022958);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonLDD2022958Exists(personLDD2022958.PersonId))
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
            return View(personLDD2022958);
        }

        // GET: PersonLDD2022958/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personLDD2022958 = await _context.PersonLDD2022958
                .FirstOrDefaultAsync(m => m.PersonId == id);
            if (personLDD2022958 == null)
            {
                return NotFound();
            }

            return View(personLDD2022958);
        }

        // POST: PersonLDD2022958/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var personLDD2022958 = await _context.PersonLDD2022958.FindAsync(id);
            _context.PersonLDD2022958.Remove(personLDD2022958);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonLDD2022958Exists(string id)
        {
            return _context.PersonLDD2022958.Any(e => e.PersonId == id);
        }
    }
}

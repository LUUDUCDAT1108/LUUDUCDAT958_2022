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
    public class LDD0958Controller : Controller
    {
        private readonly LuuDucDat2022958Context _context;

        public LDD0958Controller(LuuDucDat2022958Context context)
        {
            _context = context;
        }

        // GET: LDD0958
        public async Task<IActionResult> Index()
        {
            return View(await _context.LDD0958.ToListAsync());
        }

        // GET: LDD0958/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lDD0958 = await _context.LDD0958
                .FirstOrDefaultAsync(m => m.LDDid == id);
            if (lDD0958 == null)
            {
                return NotFound();
            }

            return View(lDD0958);
        }

        // GET: LDD0958/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LDD0958/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LDDid,LDDName,LDDGender")] LDD0958 lDD0958)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lDD0958);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lDD0958);
        }

        // GET: LDD0958/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lDD0958 = await _context.LDD0958.FindAsync(id);
            if (lDD0958 == null)
            {
                return NotFound();
            }
            return View(lDD0958);
        }

        // POST: LDD0958/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LDDid,LDDName,LDDGender")] LDD0958 lDD0958)
        {
            if (id != lDD0958.LDDid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lDD0958);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LDD0958Exists(lDD0958.LDDid))
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
            return View(lDD0958);
        }

        // GET: LDD0958/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lDD0958 = await _context.LDD0958
                .FirstOrDefaultAsync(m => m.LDDid == id);
            if (lDD0958 == null)
            {
                return NotFound();
            }

            return View(lDD0958);
        }

        // POST: LDD0958/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lDD0958 = await _context.LDD0958.FindAsync(id);
            _context.LDD0958.Remove(lDD0958);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LDD0958Exists(string id)
        {
            return _context.LDD0958.Any(e => e.LDDid == id);
        }
    }
}

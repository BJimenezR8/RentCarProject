using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentCarProject.Models;

namespace RentCarProject.Controllers
{
    public class CombustiblesController : Controller
    {
        private readonly RentCarProjectContext _context;

        public CombustiblesController(RentCarProjectContext context)
        {
            _context = context;
        }

        // GET: Combustibles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Combustibles.ToListAsync());
        }

        // GET: Combustibles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var combustible = await _context.Combustibles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (combustible == null)
            {
                return NotFound();
            }

            return View(combustible);
        }

        // GET: Combustibles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Combustibles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Tipo")] Combustible combustible)
        {
            if (ModelState.IsValid)
            {
                _context.Add(combustible);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(combustible);
        }

        // GET: Combustibles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var combustible = await _context.Combustibles.FindAsync(id);
            if (combustible == null)
            {
                return NotFound();
            }
            return View(combustible);
        }

        // POST: Combustibles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Tipo")] Combustible combustible)
        {
            if (id != combustible.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(combustible);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CombustibleExists(combustible.Id))
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
            return View(combustible);
        }

        // GET: Combustibles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var combustible = await _context.Combustibles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (combustible == null)
            {
                return NotFound();
            }

            return View(combustible);
        }

        // POST: Combustibles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var combustible = await _context.Combustibles.FindAsync(id);
            if (combustible != null)
            {
                _context.Combustibles.Remove(combustible);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CombustibleExists(int id)
        {
            return _context.Combustibles.Any(e => e.Id == id);
        }
    }
}

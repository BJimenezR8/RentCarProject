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
    public class TipoCombustiblesController : Controller
    {
        private readonly RentCarProjectContext _context;

        public TipoCombustiblesController(RentCarProjectContext context)
        {
            _context = context;
        }

        // GET: TipoCombustibles
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoCombustible.ToListAsync());
        }

        // GET: TipoCombustibles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoCombustible = await _context.TipoCombustible
                .FirstOrDefaultAsync(m => m.IdTipoCombustible == id);
            if (tipoCombustible == null)
            {
                return NotFound();
            }

            return View(tipoCombustible);
        }

        // GET: TipoCombustibles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoCombustibles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoCombustible,Descripcion,Estado")] TipoCombustible tipoCombustible)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoCombustible);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoCombustible);
        }

        // GET: TipoCombustibles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoCombustible = await _context.TipoCombustible.FindAsync(id);
            if (tipoCombustible == null)
            {
                return NotFound();
            }
            return View(tipoCombustible);
        }

        // POST: TipoCombustibles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("IdTipoCombustible,Descripcion,Estado")] TipoCombustible tipoCombustible)
        {
            if (id != tipoCombustible.IdTipoCombustible)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoCombustible);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoCombustibleExists(tipoCombustible.IdTipoCombustible))
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
            return View(tipoCombustible);
        }

        // GET: TipoCombustibles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoCombustible = await _context.TipoCombustible
                .FirstOrDefaultAsync(m => m.IdTipoCombustible == id);
            if (tipoCombustible == null)
            {
                return NotFound();
            }

            return View(tipoCombustible);
        }

        // POST: TipoCombustibles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var tipoCombustible = await _context.TipoCombustible.FindAsync(id);
            if (tipoCombustible != null)
            {
                _context.TipoCombustible.Remove(tipoCombustible);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoCombustibleExists(int? id)
        {
            return _context.TipoCombustible.Any(e => e.IdTipoCombustible == id);
        }
    }
}

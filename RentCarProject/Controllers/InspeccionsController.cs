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
    public class InspeccionsController : Controller
    {
        private readonly RentCarProjectContext _context;

        public InspeccionsController(RentCarProjectContext context)
        {
            _context = context;
        }

        // GET: Inspeccions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Inspeccion.ToListAsync());
        }

        // GET: Inspeccions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspeccion = await _context.Inspeccion
                .FirstOrDefaultAsync(m => m.IdTransaccion == id);
            if (inspeccion == null)
            {
                return NotFound();
            }

            return View(inspeccion);
        }

        // GET: Inspeccions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Inspeccions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTransaccion,IdVehiculo,IdCliente,Ralladuras,CantidadCombustible,GomaRepuesta,EstadoGomas")] Inspeccion inspeccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inspeccion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inspeccion);
        }

        // GET: Inspeccions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspeccion = await _context.Inspeccion.FindAsync(id);
            if (inspeccion == null)
            {
                return NotFound();
            }
            return View(inspeccion);
        }

        // POST: Inspeccions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("IdTransaccion,IdVehiculo,IdCliente,Ralladuras,CantidadCombustible,GomaRepuesta,EstadoGomas")] Inspeccion inspeccion)
        {
            if (id != inspeccion.IdTransaccion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inspeccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InspeccionExists(inspeccion.IdTransaccion))
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
            return View(inspeccion);
        }

        // GET: Inspeccions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspeccion = await _context.Inspeccion
                .FirstOrDefaultAsync(m => m.IdTransaccion == id);
            if (inspeccion == null)
            {
                return NotFound();
            }

            return View(inspeccion);
        }

        // POST: Inspeccions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var inspeccion = await _context.Inspeccion.FindAsync(id);
            if (inspeccion != null)
            {
                _context.Inspeccion.Remove(inspeccion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InspeccionExists(int? id)
        {
            return _context.Inspeccion.Any(e => e.IdTransaccion == id);
        }
    }
}

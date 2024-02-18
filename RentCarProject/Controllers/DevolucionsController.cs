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
    public class DevolucionsController : Controller
    {
        private readonly RentCarProjectContext _context;

        public DevolucionsController(RentCarProjectContext context)
        {
            _context = context;
        }

        // GET: Devolucions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Devolucion.ToListAsync());
        }

        // GET: Devolucions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucion = await _context.Devolucion
                .FirstOrDefaultAsync(m => m.NoRenta == id);
            if (devolucion == null)
            {
                return NotFound();
            }

            return View(devolucion);
        }

        // GET: Devolucions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Devolucions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NoRenta,IdEmpleado,IdVehiculo,IdCliente,FechaDevolucion,MontoxDia,CantidadDeDias,Comentario,Estado")] Devolucion devolucion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(devolucion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(devolucion);
        }

        // GET: Devolucions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucion = await _context.Devolucion.FindAsync(id);
            if (devolucion == null)
            {
                return NotFound();
            }
            return View(devolucion);
        }

        // POST: Devolucions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("NoRenta,IdEmpleado,IdVehiculo,IdCliente,FechaDevolucion,MontoxDia,CantidadDeDias,Comentario,Estado")] Devolucion devolucion)
        {
            if (id != devolucion.NoRenta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(devolucion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DevolucionExists(devolucion.NoRenta))
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
            return View(devolucion);
        }

        // GET: Devolucions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var devolucion = await _context.Devolucion
                .FirstOrDefaultAsync(m => m.NoRenta == id);
            if (devolucion == null)
            {
                return NotFound();
            }

            return View(devolucion);
        }

        // POST: Devolucions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var devolucion = await _context.Devolucion.FindAsync(id);
            if (devolucion != null)
            {
                _context.Devolucion.Remove(devolucion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DevolucionExists(int? id)
        {
            return _context.Devolucion.Any(e => e.NoRenta == id);
        }
    }
}

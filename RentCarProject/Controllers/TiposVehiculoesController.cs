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
    public class TiposVehiculoesController : Controller
    {
        private readonly RentCarProjectContext _context;

        public TiposVehiculoesController(RentCarProjectContext context)
        {
            _context = context;
        }

        // GET: TiposVehiculoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposVehiculo.ToListAsync());
        }

        // GET: TiposVehiculoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposVehiculo = await _context.TiposVehiculo
                .FirstOrDefaultAsync(m => m.IdTipoVehiculo == id);
            if (tiposVehiculo == null)
            {
                return NotFound();
            }

            return View(tiposVehiculo);
        }

        // GET: TiposVehiculoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposVehiculoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTipoVehiculo,Descripcion,Estado")] TiposVehiculo tiposVehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tiposVehiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tiposVehiculo);
        }

        // GET: TiposVehiculoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposVehiculo = await _context.TiposVehiculo.FindAsync(id);
            if (tiposVehiculo == null)
            {
                return NotFound();
            }
            return View(tiposVehiculo);
        }

        // POST: TiposVehiculoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("IdTipoVehiculo,Descripcion,Estado")] TiposVehiculo tiposVehiculo)
        {
            if (id != tiposVehiculo.IdTipoVehiculo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tiposVehiculo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiposVehiculoExists(tiposVehiculo.IdTipoVehiculo))
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
            return View(tiposVehiculo);
        }

        // GET: TiposVehiculoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposVehiculo = await _context.TiposVehiculo
                .FirstOrDefaultAsync(m => m.IdTipoVehiculo == id);
            if (tiposVehiculo == null)
            {
                return NotFound();
            }

            return View(tiposVehiculo);
        }

        // POST: TiposVehiculoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var tiposVehiculo = await _context.TiposVehiculo.FindAsync(id);
            if (tiposVehiculo != null)
            {
                _context.TiposVehiculo.Remove(tiposVehiculo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TiposVehiculoExists(int? id)
        {
            return _context.TiposVehiculo.Any(e => e.IdTipoVehiculo == id);
        }
    }
}

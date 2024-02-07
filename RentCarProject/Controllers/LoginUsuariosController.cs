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
    public class LoginUsuariosController : Controller
    {
        private readonly RentCarProjectContext _context;

        public LoginUsuariosController(RentCarProjectContext context)
        {
            _context = context;
        }

        // GET: LoginUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoginUsuario.ToListAsync());
        }

        // GET: LoginUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginUsuario = await _context.LoginUsuario
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (loginUsuario == null)
            {
                return NotFound();
            }

            return View(loginUsuario);
        }

        // GET: LoginUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoginUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,Name,Email")] LoginUsuario loginUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loginUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginUsuario);
        }

        // GET: LoginUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginUsuario = await _context.LoginUsuario.FindAsync(id);
            if (loginUsuario == null)
            {
                return NotFound();
            }
            return View(loginUsuario);
        }

        // POST: LoginUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,Name,Email")] LoginUsuario loginUsuario)
        {
            if (id != loginUsuario.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loginUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginUsuarioExists(loginUsuario.IdUsuario))
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
            return View(loginUsuario);
        }

        // GET: LoginUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginUsuario = await _context.LoginUsuario
                .FirstOrDefaultAsync(m => m.IdUsuario == id);
            if (loginUsuario == null)
            {
                return NotFound();
            }

            return View(loginUsuario);
        }

        // POST: LoginUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loginUsuario = await _context.LoginUsuario.FindAsync(id);
            if (loginUsuario != null)
            {
                _context.LoginUsuario.Remove(loginUsuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginUsuarioExists(int id)
        {
            return _context.LoginUsuario.Any(e => e.IdUsuario == id);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using atendimentoAlunos.Models;

namespace atendimentoAlunos.Controllers
{
    public class SalaController : Controller
    {
        private readonly Contexto _context;

        public SalaController(Contexto context)
        {
            _context = context;
        }

        // GET: Sala
        public async Task<IActionResult> Index()
        {
              return View(await _context.Sala.ToListAsync());
        }

        // GET: Sala/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sala == null)
            {
                return NotFound();
            }

            var sala = await _context.Sala
                .FirstOrDefaultAsync(m => m.id == id);
            if (sala == null)
            {
                return NotFound();
            }

            return View(sala);
        }

        // GET: Sala/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sala/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descricao,equipamentos,situacao")] Sala sala)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sala);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sala);
        }

        // GET: Sala/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sala == null)
            {
                return NotFound();
            }

            var sala = await _context.Sala.FindAsync(id);
            if (sala == null)
            {
                return NotFound();
            }
            return View(sala);
        }

        // POST: Sala/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descricao,equipamentos,situacao")] Sala sala)
        {
            if (id != sala.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sala);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalaExists(sala.id))
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
            return View(sala);
        }

        // GET: Sala/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sala == null)
            {
                return NotFound();
            }

            var sala = await _context.Sala
                .FirstOrDefaultAsync(m => m.id == id);
            if (sala == null)
            {
                return NotFound();
            }

            return View(sala);
        }

        // POST: Sala/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sala == null)
            {
                return Problem("Entity set 'Contexto.Sala'  is null.");
            }
            var sala = await _context.Sala.FindAsync(id);
            if (sala != null)
            {
                _context.Sala.Remove(sala);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SalaExists(int id)
        {
          return _context.Sala.Any(e => e.id == id);
        }
    }
}

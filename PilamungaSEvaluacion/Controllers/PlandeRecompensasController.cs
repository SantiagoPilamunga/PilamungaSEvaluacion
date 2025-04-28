using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PilamungaSEvaluacion.Data;
using PilamungaSEvaluacion.Models;

namespace PilamungaSEvaluacion.Controllers
{
    public class PlandeRecompensasController : Controller
    {
        private readonly PilamungaSEvaluacionContext _planRecompensas;

        public PlandeRecompensasController(PilamungaSEvaluacionContext context)
        {
            _planRecompensas = context;
        }

        // GET: PlandeRecompensas
        public async Task<IActionResult> Index()
        {
            return View(await _planRecompensas.PlandeRecompensas.ToListAsync());
        }

        // GET: PlandeRecompensas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plandeRecompensas = await _planRecompensas.PlandeRecompensas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plandeRecompensas == null)
            {
                return NotFound();
            }

            return View(plandeRecompensas);
        }

        // GET: PlandeRecompensas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlandeRecompensas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FechaInicio,Id,Nombre,DineroSeparar,FechaNacimiento,Asociado,NumTotalReservas")] PlandeRecompensas plandeRecompensas)
        {
            if (ModelState.IsValid)
            {
                _planRecompensas.Add(plandeRecompensas);
                await _planRecompensas.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(plandeRecompensas);
        }

        // GET: PlandeRecompensas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plandeRecompensas = await _planRecompensas.PlandeRecompensas.FindAsync(id);
            if (plandeRecompensas == null)
            {
                return NotFound();
            }
            return View(plandeRecompensas);
        }

        // POST: PlandeRecompensas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FechaInicio,Id,Nombre,DineroSeparar,FechaNacimiento,Asociado,NumTotalReservas")] PlandeRecompensas plandeRecompensas)
        {
            if (id != plandeRecompensas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _planRecompensas.Update(plandeRecompensas);
                    await _planRecompensas.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlandeRecompensasExists(plandeRecompensas.Id))
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
            return View(plandeRecompensas);
        }

        // GET: PlandeRecompensas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plandeRecompensas = await _planRecompensas.PlandeRecompensas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plandeRecompensas == null)
            {
                return NotFound();
            }

            return View(plandeRecompensas);
        }

        // POST: PlandeRecompensas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plandeRecompensas = await _planRecompensas.PlandeRecompensas.FindAsync(id);
            if (plandeRecompensas != null)
            {
                _planRecompensas.PlandeRecompensas.Remove(plandeRecompensas);
            }

            await _planRecompensas.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlandeRecompensasExists(int id)
        {
            return _planRecompensas.PlandeRecompensas.Any(e => e.Id == id);
        }
    }
}

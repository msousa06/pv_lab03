using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using lab03.Models;

namespace lab03.Controllers
{
    public class CarroDaSemanaController : Controller
    {
        private readonly lab03Context _context;

        public CarroDaSemanaController(lab03Context context)
        {
            _context = context;
        }

        // GET: Carroes
        public async Task<IActionResult> Index()
        {
            Carro carro = new Carro
            {
                Codigo = 1,
                Marca = "BMW",
                Modelo = "Serie 3 Diesel",
                NumeroDePassageiros = 5,
                NumeroDePortas = 4,
                EmissoesCO2 = 106, //g/km
                TipoDeCaixa = "Manual",
                Comentarios = new List<string> {
                 "2017-10-25 17:45. Carro rápido e confortavel. Carlos",
                 "2017-10-30 12:10. Bom carro e atendimento excelente. JR",
                 "2017-10-30 12:10. TopCAR é mesmo TOP, continuem o bom trabalho. Luis"
                }
            };

            return View(carro);
        }

        // GET: Carroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = await _context.Carro
                .SingleOrDefaultAsync(m => m.Codigo == id);
            if (carro == null)
            {
                return NotFound();
            }

            return View(carro);
        }

        // GET: Carroes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Marca,Modelo,NumeroDePassageiros,NumeroDePortas,EmissoesCO2,TipoDeCaixa")] Carro carro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carro);
        }

        // GET: Carroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = await _context.Carro.SingleOrDefaultAsync(m => m.Codigo == id);
            if (carro == null)
            {
                return NotFound();
            }
            return View(carro);
        }

        // POST: Carroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Codigo,Marca,Modelo,NumeroDePassageiros,NumeroDePortas,EmissoesCO2,TipoDeCaixa")] Carro carro)
        {
            if (id != carro.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarroExists(carro.Codigo))
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
            return View(carro);
        }

        // GET: Carroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carro = await _context.Carro
                .SingleOrDefaultAsync(m => m.Codigo == id);
            if (carro == null)
            {
                return NotFound();
            }

            return View(carro);
        }

        // POST: Carroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carro = await _context.Carro.SingleOrDefaultAsync(m => m.Codigo == id);
            _context.Carro.Remove(carro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarroExists(int id)
        {
            return _context.Carro.Any(e => e.Codigo == id);
        }
    }
}

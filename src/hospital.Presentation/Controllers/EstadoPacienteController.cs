#nullable disable
using hospital.DataAcessLayer.ORM;
using hospital.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace n1.Controllers
{
    public class EstadoPacienteController : Controller
    {
        private readonly HospitalDbContext _context;

        public EstadoPacienteController(HospitalDbContext context)
        {
            _context = context;
        }

        // GET: EstadoPacientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadoPaciente.ToListAsync());
        }

        // GET: EstadoPacientes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoPaciente = await _context.EstadoPaciente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadoPaciente == null)
            {
                return NotFound();
            }

            return View(estadoPaciente);
        }

        // GET: EstadoPacientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoPacientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descricao,Id")] EstadoPaciente estadoPaciente)
        {
            if (ModelState.IsValid)
            {
                estadoPaciente.Id = Guid.NewGuid();
                _context.Add(estadoPaciente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadoPaciente);
        }

        // GET: EstadoPacientes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoPaciente = await _context.EstadoPaciente.FindAsync(id);
            if (estadoPaciente == null)
            {
                return NotFound();
            }
            return View(estadoPaciente);
        }

        // POST: EstadoPacientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Descricao,Id")] EstadoPaciente estadoPaciente)
        {
            if (id != estadoPaciente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoPaciente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoPacienteExists(estadoPaciente.Id))
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
            return View(estadoPaciente);
        }

        // GET: EstadoPacientes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoPaciente = await _context.EstadoPaciente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadoPaciente == null)
            {
                return NotFound();
            }

            return View(estadoPaciente);
        }

        // POST: EstadoPacientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var estadoPaciente = await _context.EstadoPaciente.FindAsync(id);
            _context.EstadoPaciente.Remove(estadoPaciente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoPacienteExists(Guid id)
        {
            return _context.EstadoPaciente.Any(e => e.Id == id);
        }
    }
}

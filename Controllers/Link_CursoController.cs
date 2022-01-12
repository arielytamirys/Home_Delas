using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewJob.Data;
using NewJob.Models;

namespace NewJob.Models.Controllers
{
    public class Link_CursoController : Controller
    {
        private readonly InicialContext _context;

        public Link_CursoController(InicialContext context)
        {
            _context = context;
        }

        // GET: Link_Curso
        public async Task<IActionResult> Index()
        {
            return View(await _context.Link_Cursos.ToListAsync());
        }

        // GET: Link_Curso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Link_Curso = await _context.Link_Cursos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Link_Curso == null)
            {
                return NotFound();
            }

            return View(Link_Curso);
        }

        // GET: Link_Curso/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Link_Curso/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Link_Curso, Link_Cursos")] Link_Curso Link_Curso)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Link_Curso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Link_Curso);
        }

        // GET: Link_Curso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Link_Curso = await _context.Link_Cursos.FindAsync(id);
            if (Link_Curso == null)
            {
                return NotFound();
            }
            return View(Link_Curso);
        }

        // POST: Link_Curso/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Link_Curso, Link_Cursos")] Link_Curso Link_Curso)
        {
            if (id != Link_Curso.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Link_Curso);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Link_CursoExists(Link_Curso.Id))
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
            return View(Link_Curso);
        }

        // GET: Link_Curso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Link_Curso = await _context.Link_Cursos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Link_Curso == null)
            {
                return NotFound();
            }

            return View(Link_Curso);
        }

        // POST: Link_Curso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Link_Curso = await _context.Link_Cursos.FindAsync(id);
            _context.Link_Cursos.Remove(Link_Curso);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Link_CursoExists(int id)
        {
            return _context.Link_Cursos.Any(e => e.Id == id);
        }
    }
}

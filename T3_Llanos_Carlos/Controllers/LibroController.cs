using Microsoft.AspNetCore.Mvc;
using T3_Llanos_Carlos.Models;
using T3_Llanos_Carlos.Datos;

namespace T3_Llanos_Carlos.Controllers
{
    public class LibroController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LibroController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Libro> lista = _db.Libro;
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Crear(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libro.Add(libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }
        //Editar
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Libro.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Libro libro)
        {
            if (ModelState.IsValid)
            {
                _db.Libro.Update(libro);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(libro);
        }

        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.Libro.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Libro libro)
        {
            if (libro == null)
            {
                return NotFound();
            }
            _db.Libro.Remove(libro);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using T3_Llanos_Carlos.Models;
using UsandoCRUDValidaciones.Datos;

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
    }
}

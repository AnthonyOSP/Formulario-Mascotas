using Microsoft.AspNetCore.Mvc;
using Proyecto_1.Models;

namespace Proyecto_1.Controllers;

public class MascotasController : Controller
{
    // Almacenamiento en memoria (sin base de datos): la lista vive mientras
    // la aplicación esté corriendo y se reinicia al detenerla.
    private static readonly List<Mascota> _mascotas = new();

    public IActionResult Index()
    {
        return View(_mascotas);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Registrar(Mascota mascota)
    {
        if (ModelState.IsValid)
        {
            _mascotas.Add(mascota);
        }

        return RedirectToAction(nameof(Index));
    }
}

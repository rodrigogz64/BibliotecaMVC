using BibliotecaMVC.Models;
using BibliotecaMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers;

public class AutoresController : Controller
{
    private readonly IAutorService _autorService;

    public AutoresController(IAutorService autorService)
    {
        _autorService = autorService;
    }

    public IActionResult Index() =>
        View(_autorService.ListarAutores());

    public IActionResult Details(int id)
    {
        var autor = _autorService.ObtenerAutor(id);
        return autor is null ? NotFound() : View(autor);
    }

    public IActionResult Create() =>
        View(new Autor { Activo = true });

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Autor autor)
    {
        if (!ModelState.IsValid) return View(autor);

        _autorService.RegistrarAutor(autor);
        TempData["Mensaje"] = $"Autor \"{autor.NombreCompleto}\" agregado correctamente.";

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var autor = _autorService.ObtenerAutor(id);
        return autor is null ? NotFound() : View(autor);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Autor autor)
    {
        if (!ModelState.IsValid) return View(autor);

        if (_autorService.ObtenerAutor(autor.Id) is null) return NotFound();

        _autorService.ActualizarAutor(autor);
        TempData["Mensaje"] = $"Autor \"{autor.NombreCompleto}\" actualizado correctamente.";

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var autor = _autorService.ObtenerAutor(id);
        return autor is null ? NotFound() : View(autor);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var autor = _autorService.ObtenerAutor(id);
        if (autor is null) return NotFound();

        _autorService.EliminarAutor(id);
        TempData["Mensaje"] = $"Autor \"{autor.NombreCompleto}\" eliminado correctamente.";

        return RedirectToAction(nameof(Index));
    }
}

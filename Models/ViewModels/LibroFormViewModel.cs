using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BibliotecaMVC.Models.ViewModels;

/// <summary>
/// Formulario compartido por Create y Edit. Reutiliza el modelo de dominio para
/// no duplicar sus validaciones y le suma lo que solo existe en la pantalla:
/// el archivo de portada y el listado de autores del combo.
/// </summary>
public class LibroFormViewModel
{
    public Libro Libro { get; set; } = new();

    [Display(Name = "Portada (JPG, PNG, GIF o WEBP)")]
    public IFormFile? Imagen { get; set; }

    public string ImagenActualUrl { get; set; } = string.Empty;

    public IEnumerable<SelectListItem> Autores { get; set; } = new List<SelectListItem>();
}

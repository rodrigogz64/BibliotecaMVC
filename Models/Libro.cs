using System.ComponentModel.DataAnnotations;

namespace BibliotecaMVC.Models;

public class Libro
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El título es obligatorio.")]
    [StringLength(200, ErrorMessage = "El título no puede exceder los 200 caracteres.")]
    [Display(Name = "Título")]
    public string Titulo { get; set; } = string.Empty;

    [Required(ErrorMessage = "El ISBN es obligatorio.")]
    [StringLength(20, ErrorMessage = "El ISBN no puede exceder los 20 caracteres.")]
    [Display(Name = "ISBN")]
    public string Isbn { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un autor.")]
    [Display(Name = "Autor")]
    public int AutorId { get; set; }

    [Range(1450, 2100, ErrorMessage = "El año de publicación debe estar entre 1450 y 2100.")]
    [Display(Name = "Año de publicación")]
    public int AnioPublicacion { get; set; }

    [Required(ErrorMessage = "El género es obligatorio.")]
    [StringLength(60, ErrorMessage = "El género no puede exceder los 60 caracteres.")]
    [Display(Name = "Género")]
    public string Genero { get; set; } = string.Empty;

    [Display(Name = "Disponible")]
    public bool Disponible { get; set; }

    /// <summary>
    /// Solo el nombre del archivo guardado en wwwroot/images, no la ruta completa:
    /// así la vista no depende de dónde se almacenen físicamente las portadas.
    /// </summary>
    [Display(Name = "Portada")]
    public string ImagenNombre { get; set; } = string.Empty;
}

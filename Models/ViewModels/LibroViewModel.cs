namespace BibliotecaMVC.Models.ViewModels;

/// <summary>
/// Datos ya resueltos para mostrar un libro: el nombre del autor y la URL de la
/// portada llegan calculados para que la vista no tenga que consultar nada.
/// </summary>
public class LibroViewModel
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public string NombreAutor { get; set; } = string.Empty;
    public int AnioPublicacion { get; set; }
    public string Genero { get; set; } = string.Empty;
    public bool Disponible { get; set; }
    public string ImagenUrl { get; set; } = string.Empty;
}

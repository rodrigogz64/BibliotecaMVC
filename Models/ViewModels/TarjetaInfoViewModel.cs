namespace BibliotecaMVC.Models.ViewModels;

/// <summary>
/// Datos de la tarjeta informativa reutilizable: sirve para servicios
/// bibliotecarios, principios institucionales, categorías o características
/// del sistema. Las propiedades calculadas evitan que la vista tenga que
/// comprobar cadenas vacías.
/// </summary>
public class TarjetaInfoViewModel
{
    public string Titulo { get; init; } = string.Empty;

    public string Descripcion { get; init; } = string.Empty;

    /// <summary>
    /// Clave del icono dentro del sprite SVG de _IconosSvg.cshtml, sin el
    /// prefijo "icono-" (por ejemplo "libro" o "wifi").
    /// </summary>
    public string? Icono { get; init; }

    public EtiquetaViewModel? Etiqueta { get; init; }

    public string? EnlaceTexto { get; init; }

    public string? Controlador { get; init; }

    public string? Accion { get; init; }

    public bool TieneIcono => !string.IsNullOrWhiteSpace(Icono);

    public bool TieneEnlace =>
        !string.IsNullOrWhiteSpace(EnlaceTexto)
        && !string.IsNullOrWhiteSpace(Controlador)
        && !string.IsNullOrWhiteSpace(Accion);

    public bool TienePie => Etiqueta is not null || TieneEnlace;
}

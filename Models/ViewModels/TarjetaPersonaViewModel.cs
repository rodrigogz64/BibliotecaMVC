namespace BibliotecaMVC.Models.ViewModels;

/// <summary>
/// Datos de la tarjeta de persona reutilizable: se usa tanto para los autores
/// destacados del catálogo como para el equipo de la biblioteca.
/// </summary>
public class TarjetaPersonaViewModel
{
    public string Nombre { get; init; } = string.Empty;

    /// <summary>Iniciales que se muestran dentro del medallón circular.</summary>
    public string Iniciales { get; init; } = string.Empty;

    /// <summary>Cargo, especialidad o descripción corta de la persona.</summary>
    public string Rol { get; init; } = string.Empty;

    /// <summary>Dato secundario opcional, por ejemplo "Colombia · 1927".</summary>
    public string? Detalle { get; init; }

    public EtiquetaViewModel? Etiqueta { get; init; }

    public bool TieneDetalle => !string.IsNullOrWhiteSpace(Detalle);
}

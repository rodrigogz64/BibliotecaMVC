namespace BibliotecaMVC.Models.ViewModels;

/// <summary>
/// Datos de la etiqueta (chip) reutilizable. <see cref="Tono"/> se traduce
/// directamente al modificador CSS <c>.etiqueta--{tono}</c>, de modo que la
/// vista no tiene que decidir colores.
/// </summary>
public class EtiquetaViewModel
{
    public string Texto { get; init; } = string.Empty;

    /// <summary>primario, secundario, acento, exito, peligro, neutro o clara.</summary>
    public string Tono { get; init; } = "primario";

    /// <summary>Si se indican controlador y acción, la etiqueta se muestra como enlace.</summary>
    public string? Controlador { get; init; }

    public string? Accion { get; init; }

    public bool EsEnlace =>
        !string.IsNullOrWhiteSpace(Controlador) && !string.IsNullOrWhiteSpace(Accion);

    public string ClaseCss => $"etiqueta etiqueta--{Tono}";
}

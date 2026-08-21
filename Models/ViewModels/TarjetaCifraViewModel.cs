namespace BibliotecaMVC.Models.ViewModels;

/// <summary>
/// Datos de la tarjeta de cifra reutilizable (un número grande con su
/// leyenda). El color se decide por contexto desde el CSS del contenedor
/// (.cinta-cifras--clara), así que el componente solo transporta el dato.
/// </summary>
public class TarjetaCifraViewModel
{
    public string Valor { get; init; } = string.Empty;

    public string Etiqueta { get; init; } = string.Empty;
}

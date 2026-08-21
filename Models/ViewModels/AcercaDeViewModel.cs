namespace BibliotecaMVC.Models.ViewModels;

/// <summary>
/// Contenido que alimenta los componentes reutilizables de la página
/// "Acerca de". Las cifras y los servicios son las mismas listas que usa
/// <see cref="InicioViewModel"/>: el contenido se define una sola vez.
/// </summary>
public class AcercaDeViewModel
{
    public IReadOnlyList<TarjetaCifraViewModel> Cifras { get; init; } = [];

    /// <summary>Misión, visión y valores.</summary>
    public IReadOnlyList<TarjetaInfoViewModel> Principios { get; init; } = [];

    public IReadOnlyList<TarjetaInfoViewModel> Servicios { get; init; } = [];

    public IReadOnlyList<TarjetaPersonaViewModel> Equipo { get; init; } = [];
}

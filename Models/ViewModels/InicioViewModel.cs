namespace BibliotecaMVC.Models.ViewModels;

/// <summary>
/// Contenido que alimenta los componentes reutilizables de la página Inicio.
/// La vista solo recorre estas listas: no consulta ni calcula nada.
/// </summary>
public class InicioViewModel
{
    public IReadOnlyList<TarjetaCifraViewModel> Cifras { get; init; } = [];

    public IReadOnlyList<EtiquetaViewModel> Categorias { get; init; } = [];

    public IReadOnlyList<TarjetaInfoViewModel> Servicios { get; init; } = [];

    public IReadOnlyList<TarjetaPersonaViewModel> AutoresDestacados { get; init; } = [];
}

using BibliotecaMVC.Models.ViewModels;

namespace BibliotecaMVC.Services;

/// <summary>
/// Provee el contenido institucional que se muestra en Inicio y en
/// "Acerca de". Al estar en un único sitio, las dos páginas presentan siempre
/// las mismas cifras y los mismos servicios.
/// </summary>
public interface IContenidoPortalService
{
    IReadOnlyList<TarjetaCifraViewModel> ListarCifras();

    IReadOnlyList<EtiquetaViewModel> ListarCategorias();

    IReadOnlyList<TarjetaInfoViewModel> ListarServicios();

    /// <summary>Misión, visión y valores de la biblioteca.</summary>
    IReadOnlyList<TarjetaInfoViewModel> ListarPrincipios();

    IReadOnlyList<TarjetaPersonaViewModel> ListarAutoresDestacados();

    IReadOnlyList<TarjetaPersonaViewModel> ListarEquipo();
}

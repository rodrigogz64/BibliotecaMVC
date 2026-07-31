namespace BibliotecaMVC.Services;

public class AlmacenamientoImagenesLocal : IAlmacenamientoImagenes
{
    private const string CarpetaImagenes = "images";
    private const string PortadaPorDefecto = "sin-portada.svg";
    private const long TamanioMaximoBytes = 2 * 1024 * 1024;

    private static readonly string[] ExtensionesPermitidas = [".jpg", ".jpeg", ".png", ".gif", ".webp"];

    private readonly IWebHostEnvironment _entorno;

    public AlmacenamientoImagenesLocal(IWebHostEnvironment entorno)
    {
        _entorno = entorno;
    }

    public string? Validar(IFormFile archivo)
    {
        if (archivo.Length == 0)
            return "El archivo seleccionado está vacío.";

        if (archivo.Length > TamanioMaximoBytes)
            return "La imagen no puede pesar más de 2 MB.";

        if (!ExtensionesPermitidas.Contains(ObtenerExtension(archivo)))
            return $"Formato no permitido. Use alguno de estos: {string.Join(", ", ExtensionesPermitidas)}.";

        return null;
    }

    public async Task<string> GuardarAsync(IFormFile archivo)
    {
        var carpetaDestino = ObtenerCarpetaDestino();
        Directory.CreateDirectory(carpetaDestino);

        // Nombre único: evita que dos portadas distintas se pisen entre sí.
        var nombreArchivo = $"{Guid.NewGuid():N}{ObtenerExtension(archivo)}";

        await using var flujo = new FileStream(Path.Combine(carpetaDestino, nombreArchivo), FileMode.Create);
        await archivo.CopyToAsync(flujo);

        return nombreArchivo;
    }

    public void Eliminar(string nombreArchivo)
    {
        if (string.IsNullOrWhiteSpace(nombreArchivo) || nombreArchivo == PortadaPorDefecto)
            return;

        var rutaCompleta = Path.Combine(ObtenerCarpetaDestino(), nombreArchivo);
        if (File.Exists(rutaCompleta))
            File.Delete(rutaCompleta);
    }

    public string ObtenerUrl(string nombreArchivo)
    {
        var nombre = string.IsNullOrWhiteSpace(nombreArchivo) ? PortadaPorDefecto : nombreArchivo;
        return $"/{CarpetaImagenes}/{nombre}";
    }

    private string ObtenerCarpetaDestino() =>
        Path.Combine(_entorno.WebRootPath, CarpetaImagenes);

    private static string ObtenerExtension(IFormFile archivo) =>
        Path.GetExtension(archivo.FileName).ToLowerInvariant();
}

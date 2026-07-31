namespace BibliotecaMVC.Services;

/// <summary>
/// Abstrae dónde y cómo se guardan las portadas. Hoy es el disco local
/// (wwwroot/images); mañana podría ser un servicio en la nube sin tocar
/// el controlador.
/// </summary>
public interface IAlmacenamientoImagenes
{
    /// <summary>
    /// Devuelve el mensaje de error si el archivo no es válido, o <c>null</c> si sí lo es.
    /// </summary>
    string? Validar(IFormFile archivo);

    /// <summary>Guarda el archivo y devuelve el nombre con el que quedó almacenado.</summary>
    Task<string> GuardarAsync(IFormFile archivo);

    void Eliminar(string nombreArchivo);

    /// <summary>Ruta pública para el atributo <c>src</c>; usa una portada genérica si no hay imagen.</summary>
    string ObtenerUrl(string nombreArchivo);
}

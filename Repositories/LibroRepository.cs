using BibliotecaMVC.Models;

namespace BibliotecaMVC.Repositories;

/// <summary>
/// Repositorio en memoria de libros. Misma estrategia que <see cref="AutorRepository"/>:
/// lista estática mientras el proyecto no tenga base de datos.
/// </summary>
public class LibroRepository : ILibroRepository
{
    private static readonly List<Libro> Libros = new()
    {
        new Libro
        {
            Id = 1,
            Titulo = "Cien años de soledad",
            Isbn = "978-84-376-0494-7",
            AutorId = 1,
            AnioPublicacion = 1967,
            Genero = "Realismo mágico",
            Disponible = true,
            ImagenNombre = "cien-anios-de-soledad.jpg"
        },
        new Libro
        {
            Id = 2,
            Titulo = "La casa de los espíritus",
            Isbn = "978-84-01-33723-6",
            AutorId = 2,
            AnioPublicacion = 1982,
            Genero = "Novela",
            Disponible = true,
            ImagenNombre = "la-casa-de-los-espiritus.jpg"
        },
        new Libro
        {
            Id = 3,
            Titulo = "La ciudad y los perros",
            Isbn = "978-84-204-2764-3",
            AutorId = 3,
            AnioPublicacion = 1963,
            Genero = "Novela",
            Disponible = false,
            ImagenNombre = "la-ciudad-y-los-perros.jpg"
        },
        new Libro
        {
            Id = 4,
            Titulo = "Ficciones",
            Isbn = "978-84-206-3313-6",
            AutorId = 4,
            AnioPublicacion = 1944,
            Genero = "Cuento",
            Disponible = true,
            ImagenNombre = "ficciones.jpg"
        },
        new Libro
        {
            Id = 5,
            Titulo = "Rayuela",
            Isbn = "978-84-376-0111-3",
            AutorId = 5,
            AnioPublicacion = 1963,
            Genero = "Novela",
            Disponible = false,
            ImagenNombre = "rayuela.jpg"
        }
    };

    public IEnumerable<Libro> ObtenerTodos() =>
        Libros.OrderBy(libro => libro.Titulo).ToList();

    public Libro? ObtenerPorId(int id) =>
        Libros.FirstOrDefault(libro => libro.Id == id);

    public void Agregar(Libro libro)
    {
        libro.Id = ObtenerSiguienteId();
        Libros.Add(libro);
    }

    public void Actualizar(Libro libro)
    {
        var existente = ObtenerPorId(libro.Id);
        if (existente is null) return;

        existente.Titulo = libro.Titulo;
        existente.Isbn = libro.Isbn;
        existente.AutorId = libro.AutorId;
        existente.AnioPublicacion = libro.AnioPublicacion;
        existente.Genero = libro.Genero;
        existente.Disponible = libro.Disponible;
        existente.ImagenNombre = libro.ImagenNombre;
    }

    public void Eliminar(int id)
    {
        var libro = ObtenerPorId(id);
        if (libro is null) return;

        Libros.Remove(libro);
    }

    private static int ObtenerSiguienteId() =>
        Libros.Count == 0 ? 1 : Libros.Max(libro => libro.Id) + 1;
}

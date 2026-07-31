using BibliotecaMVC.Models;

namespace BibliotecaMVC.Repositories;

/// <summary>
/// Repositorio en memoria. La lista es estática porque todavía no hay base de
/// datos: así los cambios sobreviven entre peticiones. Al migrar a EF Core solo
/// cambia esta clase, no el servicio ni el controlador.
/// </summary>
public class AutorRepository : IAutorRepository
{
    private static readonly List<Autor> Autores = new()
    {
        new Autor
        {
            Id = 1,
            Nombre = "Gabriel",
            Apellido = "García Márquez",
            Nacionalidad = "Colombiana",
            FechaNacimiento = new DateTime(1927, 3, 6),
            Activo = true
        },
        new Autor
        {
            Id = 2,
            Nombre = "Isabel",
            Apellido = "Allende",
            Nacionalidad = "Chilena",
            FechaNacimiento = new DateTime(1942, 8, 2),
            Activo = true
        },
        new Autor
        {
            Id = 3,
            Nombre = "Mario",
            Apellido = "Vargas Llosa",
            Nacionalidad = "Peruana",
            FechaNacimiento = new DateTime(1936, 3, 28),
            Activo = true
        },
        new Autor
        {
            Id = 4,
            Nombre = "Jorge Luis",
            Apellido = "Borges",
            Nacionalidad = "Argentina",
            FechaNacimiento = new DateTime(1899, 8, 24),
            Activo = false
        },
        new Autor
        {
            Id = 5,
            Nombre = "Julio",
            Apellido = "Cortázar",
            Nacionalidad = "Argentina",
            FechaNacimiento = new DateTime(1914, 8, 26),
            Activo = false
        }
    };

    public IEnumerable<Autor> ObtenerTodos() =>
        Autores.OrderBy(autor => autor.Apellido).ThenBy(autor => autor.Nombre).ToList();

    public Autor? ObtenerPorId(int id) =>
        Autores.FirstOrDefault(autor => autor.Id == id);

    public void Agregar(Autor autor)
    {
        autor.Id = ObtenerSiguienteId();
        Autores.Add(autor);
    }

    public void Actualizar(Autor autor)
    {
        var existente = ObtenerPorId(autor.Id);
        if (existente is null) return;

        existente.Nombre = autor.Nombre;
        existente.Apellido = autor.Apellido;
        existente.Nacionalidad = autor.Nacionalidad;
        existente.FechaNacimiento = autor.FechaNacimiento;
        existente.Activo = autor.Activo;
    }

    public void Eliminar(int id)
    {
        var autor = ObtenerPorId(id);
        if (autor is null) return;

        Autores.Remove(autor);
    }

    private static int ObtenerSiguienteId() =>
        Autores.Count == 0 ? 1 : Autores.Max(autor => autor.Id) + 1;
}

using BibliotecaMVC.Models;
using BibliotecaMVC.Repositories;

namespace BibliotecaMVC.Services;

public class AutorService : IAutorService
{
    private readonly IAutorRepository _autorRepository;

    public AutorService(IAutorRepository autorRepository)
    {
        _autorRepository = autorRepository;
    }

    public IEnumerable<Autor> ListarAutores() =>
        _autorRepository.ObtenerTodos();

    public Autor? ObtenerAutor(int id) =>
        _autorRepository.ObtenerPorId(id);

    public void RegistrarAutor(Autor autor) =>
        _autorRepository.Agregar(autor);

    public void ActualizarAutor(Autor autor) =>
        _autorRepository.Actualizar(autor);

    public void EliminarAutor(int id) =>
        _autorRepository.Eliminar(id);
}

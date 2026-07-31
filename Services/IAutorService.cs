using BibliotecaMVC.Models;

namespace BibliotecaMVC.Services;

public interface IAutorService
{
    IEnumerable<Autor> ListarAutores();
    Autor? ObtenerAutor(int id);
    void RegistrarAutor(Autor autor);
    void ActualizarAutor(Autor autor);
    void EliminarAutor(int id);
}

using BibliotecaMVC.Models;

namespace BibliotecaMVC.Repositories;

public interface IAutorRepository
{
    IEnumerable<Autor> ObtenerTodos();
    Autor? ObtenerPorId(int id);
    void Agregar(Autor autor);
    void Actualizar(Autor autor);
    void Eliminar(int id);
}

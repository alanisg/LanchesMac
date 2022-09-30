using LanchesMac.Models;

namespace LanchesMac.Repositories.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}

using LanchesMac.Models;

namespace LanchesMac.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}

using LanchesMac.Models;

namespace LanchesMac.Interface
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheId); //método para acessar um lanche em específico
    }
}

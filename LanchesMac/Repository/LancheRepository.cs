using LanchesMac.Context;
using LanchesMac.Interface;
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repository
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria); //retorna todos os lanches junto com a categoria

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches. Where(p =>
        p.IsLanchePreferido).Include(c => c.Categoria); //retorna os lanches preferidos e suas categorias

        public Lanche GetLancheById(int lancheId) => _context.Lanches.FirstOrDefault(I => I.LancheId == lancheId); //FirstOrDefault = retorna o primeiro q ele encontrar
    }
}

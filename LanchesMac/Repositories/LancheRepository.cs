using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILanchesRepository
    {

        private readonly AppDbContext _contexto;
        public LancheRepository(AppDbContext contexto)
        {
           _contexto = contexto;
        }

        public IEnumerable<Lanche> Lanches => _contexto.Lanches.Include(c => c.Categoria);

        //Fazendo uma pesquisa por um valor especifico do banco de dados
        public IEnumerable<Lanche> LanchesPreferidos => _contexto.Lanches.
                                   Where(l => l.IsLanchePreferido).Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _contexto.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}

using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interface;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        //Construtor
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}

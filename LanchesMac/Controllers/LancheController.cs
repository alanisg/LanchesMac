using LanchesMac.Repositories.Interface;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILanchesRepository _lanchesRepository;
        public LancheController(ILanchesRepository lanchesRepository)
        {
            _lanchesRepository = lanchesRepository;
        }

        public IActionResult List()
        {
            //var lanche = _lanchesRepository.Lanches;
            //return View(lanche);
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lanchesRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);
        }
        
    }
}

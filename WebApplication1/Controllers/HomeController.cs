using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModel.Home;
using WebApplication1.Services;
using WebApplication1.Contexts;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;

        public HomeController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IActionResult> Home()
        {
            var viewModel = new HomeViewModel();
            var appProducts = await _dataContext.Products.ToListAsync();

            foreach (var prod in appProducts)
            {
                viewModel.Product.Add(prod);
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Products()
        {
            var viewModel = new HomeViewModel();
            var appProducts = await _dataContext.Products.ToListAsync();

            foreach (var prod in appProducts)
            {
                viewModel.Product.Add(prod);
            }
            return View(viewModel);
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel();
            var appProducts = await _dataContext.Products.ToListAsync();

            foreach (var prod in appProducts)
            {
                viewModel.Product.Add(prod);
            }
            return View(viewModel);
        }
    }
}

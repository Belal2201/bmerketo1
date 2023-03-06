using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contexts;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DataContext _dataContext;

        public ProductsController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [Authorize(Roles = "Administrator, ProductManager")]
        public IActionResult AddProduct()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

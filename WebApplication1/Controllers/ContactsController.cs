using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Forms;

namespace WebApplication1.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactForm form)
        {
            return View();
        }
    }
}

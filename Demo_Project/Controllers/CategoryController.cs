using Microsoft.AspNetCore.Mvc;

namespace Demo_Project.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

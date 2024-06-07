using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

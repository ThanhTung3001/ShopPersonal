using Microsoft.AspNetCore.Mvc;

namespace WebApp.AreaAdmin
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

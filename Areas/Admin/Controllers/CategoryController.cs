using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ShopAppContext shopApp = new ShopAppContext();
        public IActionResult Index()
        {
            var categories = shopApp.Categories;

            ViewBag.Categories = categories;

            return View();
        }
        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            shopApp.Categories.Attach(shopApp.Categories.Find(id));
            shopApp.Categories.Remove(shopApp.Categories.Find(id));
            shopApp.SaveChanges();
            return Ok(new
            {
                message = "DeleteSuccess"
            });

        }
        [HttpPost]
        public IActionResult Add ([FromBody] Category category)
        {
            shopApp.Add(category);
            shopApp.SaveChanges();
            return Ok(new
            {
                message = "Add success"
            });
        }
    }
}

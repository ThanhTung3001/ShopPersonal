using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ShopAppContext shopApp = new ShopAppContext();
        public IActionResult Index()
        {
            var products = shopApp.Products;
            products.ToList().ForEach(product =>
            {
                product.Attachments = shopApp.Attachments.Where(attachment => attachment.IdProduct == product.Id).ToList();
            });
            ViewBag.Products = products;
            ViewBag.Categories = shopApp.Categories;
            return View();
           
        }
        [Route("SingleProduct/{id}")]
        public IActionResult SingleProduct([FromRoute] int id)
        {
            var products = shopApp.Products.Find(id);
            products.Attachments = shopApp.Attachments.Where(a => a.IdProduct == products.Id).ToList();
            ViewBag.Products = products;
            ViewBag.Categories = shopApp.Categories;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ShopAppContext shopApp =new ShopAppContext();
        private IHostingEnvironment Environment;
        public ProductController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }
        public IActionResult Index()
        {
            var products = shopApp.Products;
            ViewBag.Products = products;
            ViewBag.Categories = shopApp.Categories;
            return View();
        }
        [HttpPost]
        public IActionResult uploadProduct([FromForm] string product,[FromForm] List<IFormFile> files)
        {
            try
            {
                string wwwPath = Environment.WebRootPath;
                string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                var result = JsonConvert.DeserializeObject<Product>(product);
                shopApp.Add(result);
                shopApp.SaveChanges();


                List<string> uploadedFiles = new List<string>();
                foreach (IFormFile postedFile in files)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);
                    using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        postedFile.CopyTo(stream);
                        uploadedFiles.Add(fileName);
                        ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
                    }
                    Attachment attachment = new Attachment
                    {
                        Path = $"Uploads/{fileName}",
                        Name = fileName,
                        Type = fileName.Substring(fileName.LastIndexOf('.') + 1),
                        IdProduct = result.Id


                    };
                    shopApp.Add(attachment);
                    shopApp.SaveChanges();

                 
                }
            }catch (Exception ex)
            {
                throw ex;
            }
            
            return RedirectToAction("Index", "Product");

        }
        [HttpDelete]
        public IActionResult Delete([FromQuery]int id)
        {
            try
            {
                Product product = new Product { Id = id };
               
                Attachment attachment = shopApp.Attachments.FirstOrDefault(e=>e.IdProduct==id);
                if (attachment != null)
                {
                    shopApp.Attachments.Attach(attachment);
                    shopApp.Attachments.Remove(attachment);
                    shopApp.SaveChanges();
                }
                shopApp.Products.Attach(product);
                shopApp.Products.Remove(product);
                shopApp.SaveChanges();

                return Ok(new {
                    message="Delete Success"
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }
        public IActionResult Get([FromQuery] int id)
        {
            Product product = shopApp.Products.Find(id);
            var attachments = shopApp.Attachments.Where(e => e.IdProduct == id).ToList();
            if (attachments.Count > 0)
            {
                product.Attachments = attachments;
            }
            ViewBag.Categories = shopApp.Categories;
            ViewData["Product"] = product;
            return View();
        }
        [HttpPost]
        public IActionResult UpdateProduct([FromForm] List<IFormFile> files,[FromForm] string product)
        {
            try
            {
                string wwwPath = Environment.WebRootPath;
                string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                var result = JsonConvert.DeserializeObject<Product>(product);
                var productId = shopApp.Products.Find(result.Id);
                if (product != null)
                {
                    productId.Quanlity  = result.Quanlity;
                    productId.Description = result.Description;
                    productId.Price = result.Price;
                    productId.ProductName = result.ProductName; 
                    productId.CategoryId = result.CategoryId;
                    
                    shopApp.SaveChanges();
                }
              


                List<string> uploadedFiles = new List<string>();
                foreach (IFormFile postedFile in files)
                {
                    string fileName = Path.GetFileName(postedFile.FileName);
                    using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        postedFile.CopyTo(stream);
                        uploadedFiles.Add(fileName);
                        ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
                    }
                    Attachment attachment = new Attachment
                    {
                        Path = $"Uploads/{fileName}",
                        Name = fileName,
                        Type = fileName.Substring(fileName.LastIndexOf('.') + 1),
                        IdProduct = result.Id


                    };
                    shopApp.Add(attachment);
                    shopApp.SaveChanges();


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return RedirectToAction("Index", "Product");

        }
        
        [HttpDelete]
        public IActionResult DeleteFile(int id)
        {
            try
            {
                Attachment attachment = shopApp.Attachments.Find(id);
                shopApp.Attachments.Attach(attachment);
                shopApp.Attachments.Remove(attachment);
                shopApp.SaveChanges();
                return Ok(new
                {
                    Message="Delete sucess!!"
                });
            }catch (Exception ex)
            {
                throw ex;
            }
            
        }
     
    
   
    }
}

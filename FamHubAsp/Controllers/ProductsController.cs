using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using FamHubAsp.Data;
using FamHubAsp.Models;
using System.Linq;

namespace FamHubAsp.Controllers
{
    public class ProductsController : Controller
    {
        public readonly MongoContext context = new MongoContext();

        public ActionResult Index()
        {
            var result = context.db.GetCollection<Product>("Products").Find(FilterDefinition<Product>.Empty).ToList();
            return View(result);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                var sku = new Product(product);
                context.Products.InsertOne(sku);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
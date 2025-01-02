using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using MyIceDream.Areas.Identity.Data;
using MyIceDream.Models;

namespace MyIceDream.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
    //    private static List<Product> products = new List<Product>
    //{
    //    new Product { Id = 1, Name = "Laptop", Price = 1000, ImageData = null },
    //    new Product { Id = 2, Name = "Smartphone", Price = 500, ImageData = null }
    //};

        public ActionResult Index()
        {
            // Here we would normally get the data from a database.
            List<Product> products = _context.Products.ToList();
            return View(products);
        }


        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

    
        // POST: Product/Create
        [HttpPost]
        
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {

                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
           
           

            return View(product);
        }

       
    }
}


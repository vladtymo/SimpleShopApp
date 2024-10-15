using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleShopApp.Data;
using SimpleShopApp.Models;
using System.Diagnostics;

namespace SimpleShopApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            // load data...
            // Include() - LEFT JOIN
            var items = context.Products.Include(x => x.Category).ToList();
            return View(items);
        }

        public IActionResult Manage()
        {
            var items = context.Products.Include(x => x.Category).ToList();
            return View(items);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            if(!ModelState.IsValid) 
                return View(model);

            context.Products.Add(model);
            context.SaveChanges();

            return RedirectToAction("Manage");
        }

        [Authorize(Roles ="Admin")]
        public IActionResult Delete(int id)
        {
            var item = context.Products.Find(id);
            if (item == null) return NotFound(); // 404

            context.Products.Remove(item);
            context.SaveChanges(); // execute commands

            return RedirectToAction("Manage");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

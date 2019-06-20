using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FDMC.App.Models;
using FDMC.App.Models.ViewModels;
using FDMC.Data.Data;

namespace FDMC.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly FdmcDbContext _context;

        public HomeController(FdmcDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cats = this._context.Cats
                .Select(cat => new CatConcseViewModel()
                {
                    Id = cat.Id,
                    Name = cat.Name
                }).ToArray();
                
            return View(cats);
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

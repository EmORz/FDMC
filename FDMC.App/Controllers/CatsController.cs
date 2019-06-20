using FDMC.App.Models.BindingViewModels;
using FDMC.App.Models.ViewModels;
using FDMC.Data.Data;
using FDMC.Model;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.App.Controllers
{
    public class CatsController : Controller
    {
        private readonly FdmcDbContext _context;

        public CatsController(FdmcDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Add(CatCreateBindingModel model)
        {
            var cat = new Cat()
            {
                Name = model.Name,
                Age = model.Age,
                Breed = model.Breed,
                ImageUrl = model.ImageUrl

            };
            this._context.Cats.Add(cat);
            this._context.SaveChanges();

            //return this.RedirectToRoute("default", new {controller = "Cats", action = "Details", id = model.Id});
            return this.RedirectToAction("Details", new {id = cat.Id});
        }

        public IActionResult Add()
        {
            return this.View();
        }

        public IActionResult Details(string id)
        {
            var cat = this._context.Cats.Find(id);
      
            if (cat == null)
            {
                return NotFound();
            }
            var catModel = new CatDetailsViewModel()
            {
                Name = cat.Name,
                Age = cat.Age,
                Breed = cat.Breed,
                ImageUrl = cat.ImageUrl
            };
            return View(catModel);
        }
        
    }
}
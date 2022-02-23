using Microsoft.EntityFrameworkCore;
using crudelicious.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        // here we can "inject" our context service into the constructor
        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllDishes = _context.Dishes.OrderByDescending(d => d.CreatedAt).ToList();
            return View("index");
        }

         [HttpGet("ShowDish/{dId}")]
        public IActionResult oneDish(int dId)
        {
            Dish one = _context.Dishes.FirstOrDefault(d => d.dishid == dId);
            return View("showdish");
        
        }
        [HttpGet("Addform")]
        public IActionResult Add()
        {
            return View("newDish");
        }

        [HttpPost("newDish")]
        public IActionResult addDish(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("newdish");
            }
        }

        
          [HttpGet("editDish/{dId}")]
        public IActionResult Edit(int dId)
        {
            Dish edit = _context.Dishes.FirstOrDefault(d => d.dishid == dId);
            return View("updatedish");
        }

            [HttpPost("updatedish/{dId}")]
        public IActionResult Update(int dId,Dish edited )
        {
            edited.dishid =  dId;
            if (ModelState.IsValid)
            {
                
                Dish original = _context.Dishes.FirstOrDefault(d => d.dishid == dId);
                original.name = edited.name;
                original.chef = edited.chef;
                original.tastiness = edited.tastiness;
                original.calories = edited.calories;
                original.description = edited.description;
                original.UpdatedAt = DateTime.Now;

                _context.SaveChanges();
                return View("showdish",original);
            } else{
                return View("updatedish", edited);
            } 


        }
            [HttpGet("delete/{dId}")]
        public IActionResult DeleteDish(int dId)
        {
            Dish toDelete = _context.Dishes.SingleOrDefault(d => d.dishid == dId);
            _context.Dishes.Remove(toDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
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

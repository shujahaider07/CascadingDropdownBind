using CascadingDropdownBind.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CascadingDropdownBind.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;



        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            this._context = _context;
        }

        public JsonResult Country()
        {

            var countires = _context.countries.ToList();
            return new JsonResult(countires);
        }
        public JsonResult City(int id)
        {
            var Cities = _context.Cities.Where(x => x.country.Id == id).ToList();

            return new JsonResult(Cities);
        }   




        public IActionResult CascadeDropdown()
        {
            return View();
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
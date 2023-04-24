using Microsoft.AspNetCore.Mvc;
using SaveDetails.Data;
using SaveDetails.Models;
using System.Diagnostics;

namespace SaveDetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext database;

        public HomeController(ApplicationDbContext db,ILogger<HomeController> logger)
        {
            _logger = logger;
            database = db;
        }

        // Action method to display default "Index" view
        public IActionResult Index()
        {
            return View();
        }

        // Action method to display "Save" view, and passes a list of ProjectModel objects to the view
        public IActionResult Save()
        {
            IEnumerable<ProjectModel> objSaveList = database.Project;
            return View(objSaveList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ProjectModel obj)
        {
            if (ModelState.IsValid)
            {
                database.Project.Add(obj);
                database.SaveChanges();
                return RedirectToAction("Save");
            }
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        // Action method to handle errors and display the "Error" view
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
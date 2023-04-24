using Microsoft.AspNetCore.Mvc;
using SaveDetails.Controllers;
using SaveDetails.Data;
using SaveDetails.Models;

namespace ProjectDetails.Controllers
{
    public class SaveController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SaveController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ProjectModel> objSaveList = _db.Project;
            return View(objSaveList);
        }
    }
}

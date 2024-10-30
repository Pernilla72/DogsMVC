using DogsMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogsMVC.Controllers
{
    public class DogController : Controller
    {
            static DataService _dataService = new DataService();

            [HttpGet("")]
            public IActionResult Index()
            {
                var model = _dataService.GetAllDogs();
                return View(model);
            }

            [HttpGet("/Details/{id}")]
            public IActionResult Details(int id)
            {
                var model = _dataService.GetDogById(id);
                return View(model);
            }

            [HttpPost("Create")]
            public IActionResult Create(Dog dog)
            {
                
                return RedirectToAction(nameof(Index));
            }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }       
}


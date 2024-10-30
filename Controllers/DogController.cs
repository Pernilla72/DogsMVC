using DogsMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DogsMVC.Controllers
{
    public class DogController : Controller
    {
            static DataService _dataService = new DataService();

            public DogController(DataService dataService)
            {
                _dataService = dataService;
            }

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

       
            [HttpGet("/Dog/CreateDog")]
            public IActionResult CreateDog()
            {
                return View();
            }
        

        [HttpPost("Create")]
            public IActionResult CreateDog(Dog dog)
            {

            if (ModelState.IsValid)
                {
                    _dataService.AddDog(dog); // Förutsatt att _dataService är en instans av DataService
                    return RedirectToAction("Index"); // Tillbaka till listan med hundar
                }
            return View(dog);
            }



        //public IActionResult Index()
        //{
        //    return View();
        //}
    }       
}


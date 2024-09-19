using Microsoft.AspNetCore.Mvc;
using WestCoast_Cars.Models;
using WestCoast_Cars.ViewModels;

namespace WestCoast_Cars.Controllers
{
    [Route("vehicles")]
    public class VehiclesController : Controller
    {
        // GET: VehiclesController
        public IActionResult Index()
        {
            VehicleModel model = new VehicleModel();
            List<VehicleViewModel> vehicleList = model.GetVehicles();
            return View("Index", vehicleList);
        }

        // https://domainnamn/vehicles/5 GET
        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            VehicleModel model = new();
            VehicleViewModel vehicle = model.Find(id);
            return View("Details", vehicle);
        }

        // Parvisa action metoder för att först hämta ett inmatningsformulär
        // och en för att skicka in nytt data(ny bil)...
        [HttpGet("create")]
        public IActionResult Create()
        {
            // Skapa ett nytt objekt av typen VehicleViewModel och skicka den till vy (Create)...
            VehicleViewModel vehicle = new();
            return View("Create", vehicle);
        }

        [HttpPost("create")]
        public IActionResult Create(VehicleViewModel vehicle)
        {
            // Spara ner en ny bil någonstans...
            return RedirectToAction(nameof(Index));
        }
    }
}

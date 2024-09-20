using Microsoft.AspNetCore.Mvc;
using WestCoast_Cars.Models;
using WestCoast_Cars.ViewModels;

namespace WestCoast_Cars.Controllers
{
    [Route("vehicles")]
    public class VehiclesController : Controller
    {
        /* PRIVATE FIELDS */
        private readonly VehicleModel _model;

        /* CONSTRUCTORS */
        public VehiclesController(VehicleModel model)
        {
            _model = model;
        }
        /* ACTION METHODS */
        public async Task<IActionResult> Index()
        {
            // Anropa vehicleModel och metoden ListVehicles;
            List<VehicleViewModel> vehicleList = await _model.GetAllVehicles();
            return View("Index", vehicleList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            VehicleViewModel vehicle = await _model.Find(id);
            return View("Details", vehicle);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            VehicleViewModel model = new();
            return View("Create", model);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(VehicleViewModel vehicle)
        {
            try
            {
                if (await _model.Create(vehicle))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View("ErrorPage", new ErrorPageViewModel { Message = "Något hände när bilen skulle sparas" });
                }
            }
            catch (AppException ex)
            {
                return View("ErrorPage", new ErrorPageViewModel { Message = ex.Message, Details = ex.Details });
            }
        }
    }
}

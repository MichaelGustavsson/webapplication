using Microsoft.EntityFrameworkCore;
using WestCoast_Cars.Data;
using WestCoast_Cars.ViewModels;

namespace WestCoast_Cars.Models;

public class VehicleModel
{
  /* PRIVATE FIELDS */
  private readonly WestcoastCarsContext _context;

  /* CONSTRUCTORS */
  public VehicleModel(WestcoastCarsContext context)
  {
    _context = context;
  }

  /* METHODS */
  public async Task<List<VehicleViewModel>> GetAllVehicles()
  {
    // Hämta datat ifrån databasen...
    var vehicles = await _context.Vehicles.ToListAsync();
    return vehicles;
  }

  public async Task<VehicleViewModel> Find(int id)
  {
    return await _context.Vehicles.FindAsync(id) ?? new VehicleViewModel();
  }
}

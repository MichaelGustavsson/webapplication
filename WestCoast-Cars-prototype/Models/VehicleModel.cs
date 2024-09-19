using WestCoast_Cars.ViewModels;

namespace WestCoast_Cars.Models;

public class VehicleModel
{
  /* METHODS */
  public List<VehicleViewModel> GetVehicles()
  {
    // Hämta datat någonstans ifrån...
    // Fejk anrop till en databas...
    List<VehicleViewModel> list = [
      new VehicleViewModel{Id=1, RegNo="ABC123", Make="Volvo", Model="V60",ModelYear=2019},
      new VehicleViewModel{Id=1, RegNo="DEF456", Make="Ford", Model="Mustang MACH-E",ModelYear=2023},
      new VehicleViewModel{Id=1, RegNo="GHI789", Make="KIA", Model="EV6",ModelYear=2022},
    ];

    return list;
  }

  public VehicleViewModel Find(int id)
  {
    return new VehicleViewModel { Id = 1, RegNo = "DEF456", Make = "Ford", Model = "Mustang MACH-E", ModelYear = 2023 };
  }
}

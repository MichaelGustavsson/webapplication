namespace WestCoast_Cars;

public class VehicleModel
{
  /* METHODS */
  public List<VehicleViewModel> Vehicles()
  {
    // Hämta datat någonstans ifrån...
    // För varje fordon i det jag får tillbaka.
    List<VehicleViewModel> list = [];

    for (int i = 0; i < 10; i++)
    {
      VehicleViewModel vehicle = new VehicleViewModel
      {
        RegNo = "111222R",
        Make = "Volvo",
        Model = "V60",
        ModelYear = 2020
      };

    }
    return list;
  }
}

using Microsoft.EntityFrameworkCore;
using WestCoast_Cars.ViewModels;

namespace WestCoast_Cars.Data;

public class WestcoastCarsContext : DbContext
{
    /* PROPERTIES */
    public DbSet<VehicleViewModel> Vehicles { get; set; }

    /* CONSTRUCTORS */
    public WestcoastCarsContext(DbContextOptions options) : base(options) { }
}

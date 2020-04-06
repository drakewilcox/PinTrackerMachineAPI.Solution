using Microsoft.EntityFrameworkCore;

namespace PinTrackerAPI.Models
{
  public class PinTrackerAPIContext : DbContext
  {
    public PinTrackerAPIContext(DbContextOptions<PinTrackerAPIContext> options)
      : base(options)
    {

    }
    public DbSet<Machine> Machines { get; }
    
  }
}
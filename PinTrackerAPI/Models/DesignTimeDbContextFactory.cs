using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PinTrackerAPI.Models
{
  public class PinTrackerAPIContextFactory : IDesignTimeDbContextFactory<PinTrackerAPIContext>
  {
    PinTrackerAPIContext IDesignTimeDbContextFactory<PinTrackerAPIContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PinTrackerAPIContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new PinTrackerAPIContext(builder.Options);
    }
  }
}
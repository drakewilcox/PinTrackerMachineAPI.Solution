using System.ComponentModel.DataAnnotations;

namespace PinTrackerAPI
{
  public class Machine
  {
    public int MachineId { get; set; }
    public string MachineName { get; set; }
    public int MachineYear { get; set; }
    public string Manufacturer { get; set; }
  }
}
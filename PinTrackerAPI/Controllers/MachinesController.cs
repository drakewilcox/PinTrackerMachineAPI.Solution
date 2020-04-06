using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PinTrackerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace PinTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachinesController : ControllerBase
    {
        private  PinTrackerAPIContext _db;
        public MachinesController(PinTrackerAPIContext db)
        {
          _db = db;
        }
    [HttpGet]
    public ActionResult<IEnumerable<Machine>> Get(string machineName)
    {
      var query = _db.Machines.AsQueryable();
      
      if (machineName != null)
      {
        query = query.Where(mach => mach.MachineName == machineName);
      }
      return query.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Machine> Get(int id)
    {
      Machine thisMachine = _db.Machines.FirstOrDefault(mach => mach.MachineId == id);

      return thisMachine;
    }
  }
}









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
    public ActionResult<IEnumerable<Machine>> Get()
    {
      return _db.Machines.ToList();
    }
  }
}



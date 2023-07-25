using FormulaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FormulaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DriversController : ControllerBase 
{
    // In memory DB
    private static List<Driver> _drivers = new List<Driver>(){
        new Driver()
        {
            Id = 1,
            Name = "Lewis Hamilton",
            Team = "Mercedes AMG F1",
            DriverNumber = 44
        },
        new Driver()
        {
            Id = 2,
            Name = "George Russel",
            Team = "Mercedes AMG F1",
            DriverNumber = 63
        },
        new Driver()
        {
            Id = 3,
            Name = "Sebastian Vittel",
            Team = "Austin Martin",
            DriverNumber = 5
        }
   
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_drivers);
    }

    [HttpGet("GetById")]
    // [Route("GetById")]
    public IActionResult Get(int id)
    {
        return Ok(_drivers.FirstOrDefault(x => x.Id == id));
    }

    [HttpPost("AddDriver")]
    public IActionResult AddDriver(Driver driver)
    {
        _drivers.Add(driver);
        return Ok();
    }

    [HttpDelete("DeleteDriver")]
    public IActionResult DeleteDriver(int id)
    {
        var driver = _drivers.FirstOrDefault(x => x.Id == id);

        if(driver == null) return NotFound();

        _drivers.Remove(driver);
        return NoContent();
    }

    [HttpPatch("UpdateDriver")]
    public IActionResult UpdateDriver(Driver driver)
    {
        var existingDriver = _drivers.FirstOrDefault(x => x.Id == driver.Id);

        if(existingDriver == null) return NotFound();

        existingDriver.Name = driver.Name;
        existingDriver.Team = driver.Team;
        existingDriver.DriverNumber = driver.DriverNumber;

        return NoContent();
    }
}
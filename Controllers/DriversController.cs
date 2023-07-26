using FormulaApi.Data;
using FormulaApi.Interface;
using FormulaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormulaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DriversController : ControllerBase
{
    private readonly ApiDbContext _context;
    private readonly IDriverRepo _driverRepo;

    public DriversController(ApiDbContext context, IDriverRepo driverRepo)
    {
        _context = context;
        _driverRepo = driverRepo;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _context.Drivers.ToListAsync());
    }

    [HttpGet("test")]
    public async Task<string> test()
    {
        var resp = await _driverRepo.Get();
        return resp;
    }


    [HttpGet("GetById")]
    public async Task<IActionResult> Get(int id)
    {
        var driver = await _context.Drivers.FirstOrDefaultAsync(x => x.Id == id);

        if (driver == null) return NotFound();

        return Ok(driver);
    }

    [HttpPost("AddDriver")]
    public async Task<IActionResult> AddDriver(Driver driver)
    {
        _context.Drivers.Add(driver);

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete("DeleteDriver")]
    public async Task<IActionResult> DeleteDriver(int id)
    {
        var driver = await _context.Drivers.FirstOrDefaultAsync(x => x.Id == id);

        if (driver == null) return NotFound();

        _context.Drivers.Remove(driver);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPatch("UpdateDriver")]
    public async Task<IActionResult> UpdateDriver(Driver driver)
    {
        var existingDriver = await _context.Drivers.FirstOrDefaultAsync(x => x.Id == driver.Id);

        if (existingDriver == null) return NotFound();

        existingDriver.Name = driver.Name;
        existingDriver.Team = driver.Team;
        existingDriver.DriverNumber = driver.DriverNumber;

        await _context.SaveChangesAsync();

        return NoContent();
    }
}
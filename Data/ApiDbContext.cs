using FormulaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FormulaApi.Data;

public class ApiDbContext : DbContext
{
    // Passing the configuration into Constructor
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }

    protected ApiDbContext()
    {
    }

    // Creating the tables
    public DbSet<Driver> Drivers {get; set;}
}
using Microsoft.EntityFrameworkCore;
using NZWalks.Models.Domain;

namespace NZWalks.Data
{
    public class NZWalksDbContext : DbContext
    {
        // Constructor - In this we have to pass the DB options as later we have to send our own connections through Program.cs files
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        // DbSet properties represents the collections inside our DB.
        // These 3 properties will create tables inside our DB on running migration commands.
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

    }
}
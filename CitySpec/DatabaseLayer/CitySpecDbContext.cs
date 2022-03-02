using CitySpec.DatabaseLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace CitySpec.DatabaseLayer;

public class CitySpecDbContext : DbContext
{
    public DbSet<Area> Areas { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Filter> Filters { get; set; }
    public DbSet<Manual> Manuals { get; set; }
    public DbSet<Specification> Specifications { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    
    public CitySpecDbContext(DbContextOptions<CitySpecDbContext> options)
        : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = Environment.GetEnvironmentVariable("CitySpec_Database_Connection_String") ?? string.Empty;
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
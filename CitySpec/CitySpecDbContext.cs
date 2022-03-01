using CitySpec.Model;
using Microsoft.EntityFrameworkCore;

namespace CitySpec;

public class CitySpecDbContext : DbContext
{
    private const string ConnectionString = @"Server=(localdb)";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();
    }

    public DbSet<Area> Areas { get; set; }
    public DbSet<AreaFilter> AreaFilters { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Filter> Filters { get; set; }
    public DbSet<Manual> Manuals { get; set; }
    public DbSet<ManualArea> ManualAreas { get; set; }
    public DbSet<ManualFilter> ManualFilters { get; set; }
    public DbSet<Specification> Specifications { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<SubjectFilter> SubjectFilters { get; set; }
}
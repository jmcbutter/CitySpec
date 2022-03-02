using CitySpec.Model;
using Microsoft.EntityFrameworkCore;

namespace CitySpec;

public class CitySpecDbContext : DbContext
{
    private const string ConnectionString = @"Server=(localdb)";
    
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
        optionsBuilder.UseSqlServer();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
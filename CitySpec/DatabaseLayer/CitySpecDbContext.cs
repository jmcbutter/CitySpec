using CitySpec.Model;
using Microsoft.EntityFrameworkCore;

namespace CitySpec.Model;

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
        const string connectionString = "";
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
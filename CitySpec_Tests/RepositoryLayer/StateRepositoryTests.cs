using System.Threading.Tasks;
using CitySpec.DatabaseLayer;
using CitySpec.DatabaseLayer.Models;
using CitySpec.RepositoryLayer;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace TestProject1.RepositoryLayer;

public class StateRepositoryTests
{
    private CitySpecDbContext _context;
    private StateRepository _repository;

    public StateRepositoryTests()
    {
        TestInitialize();
    }
    
    private void TestInitialize()
    {
        DbContextOptions<CitySpecDbContext> dbContextOptions =
            new DbContextOptionsBuilder<CitySpecDbContext>().UseInMemoryDatabase("CitySpec").Options;
        _context = new CitySpecDbContext(dbContextOptions);

        State state = new State();
        _context.States.Add(state);
        _context.SaveChanges();
        
        _repository = new StateRepository();
        Assert.NotNull(_repository);
    }
    
    [Fact]
    public void GetStateByName_Success()
    {
        
    }
}
using System.Linq;
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

        State state = new State
        {
            StateId = 0,
            StateName = "Alabama"
        };
        
        _context.States.Add(state);
        _context.SaveChanges();
        
        _repository = new StateRepository();
        Assert.NotNull(_repository);
    }
    
    [Fact]
    public async Task GetStateByName_Success()
    { 
        State state = await _repository.GetStateByName("Alabama");
        State dbState = _context.States.First();
        Assert.NotNull(state);
        
        Assert.Equal(state.StateId, dbState.StateId);
        Assert.Equal(state.StateName, dbState.StateName);
    }
}
using System.Reflection;
using System.Runtime.CompilerServices;
using CitySpec.DatabaseLayer.EFModels;
using Microsoft.EntityFrameworkCore;

namespace CitySpec.DatabaseLayer.RepositoryLayer;

public class StateRepository
{
    private readonly CitySpecDbContext _context;

    public StateRepository(CitySpecDbContext context)
    {
        _context = context;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StateRepository()
    {
        if (Assembly.GetExecutingAssembly().FullName == Assembly.GetCallingAssembly().FullName)
        {
            throw new Exception("This constructor should only be used for testing");
        }
    }

    public virtual async Task<State> GetStateByName(string name)
    {
        if (IsInvalidStateName(name))
        {
            throw new StateNotFoundException();
        }

        return await _context.States.FirstOrDefaultAsync(s => s.StateName == name) ??
               throw new StateNotFoundException();
    }
}
using SimpleSolution.SetupService.Entities;
using SimpleSolution.SharedApi.RepoImpl;

namespace SimpleSolution.VendorService.Repositories;

public class StateRepository : GenericRepo<State, long>
{
    public StateRepository(SetupContext context, ILogger<StateRepository> logger) : base(context, logger)
    {
    }
}


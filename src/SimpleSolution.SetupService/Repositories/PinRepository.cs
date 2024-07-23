using SimpleSolution.SetupService.Entities;
using SimpleSolution.SharedApi.RepoImpl;

namespace SimpleSolution.VendorService.Repositories;

public class PinRepository : GenericRepo<Pin, long>
{
    public PinRepository(SetupContext context, ILogger<PinRepository> logger) : base(context, logger)
    {
    }
}


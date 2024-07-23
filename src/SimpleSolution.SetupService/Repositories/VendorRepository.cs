using SimpleSolution.SetupService.Entities;
using SimpleSolution.SharedApi.RepoImpl;

namespace SimpleSolution.VendorService.Repositories;

public class VendorRepository : GenericRepo<Vendor, long>
{
    public VendorRepository(SetupContext context, ILogger<VendorRepository> logger) : base(context, logger)
    {
    }
}


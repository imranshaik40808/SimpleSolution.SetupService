using SimpleSolution.SetupService.Entities;
using SimpleSolution.SharedApi.RepoImpl;

namespace SimpleSolution.VendorService.Repositories;

public class CountryRepository : GenericRepo<Country, long>
{
    public CountryRepository(SetupContext context, ILogger<CountryRepository> logger) : base(context, logger)
    {
    }
}


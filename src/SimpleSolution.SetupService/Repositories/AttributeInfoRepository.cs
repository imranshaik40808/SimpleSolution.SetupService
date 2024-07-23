using SimpleSolution.SetupService.Entities;
using SimpleSolution.SharedApi.RepoImpl;

namespace SimpleSolution.VendorService.Repositories;

public class AttributeInfoRepository : GenericRepo<AttributeInfo, long>
{
    public AttributeInfoRepository(SetupContext context, ILogger<AttributeInfoRepository> logger) : base(context, logger)
    {
    }
}


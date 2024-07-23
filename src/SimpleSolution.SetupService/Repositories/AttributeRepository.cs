using Attribute = SimpleSolution.SetupService.Entities.Attribute;
using SimpleSolution.SharedApi.RepoImpl;

namespace SimpleSolution.VendorService.Repositories;

public class AttributeRepository : GenericRepo<Attribute, long>
{
    public AttributeRepository(SetupContext context, ILogger<AttributeRepository> logger) : base(context, logger)
    {
    }
}


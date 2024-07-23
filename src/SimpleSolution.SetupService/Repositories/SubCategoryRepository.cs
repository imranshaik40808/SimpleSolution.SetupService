using SimpleSolution.SetupService.Entities;
using SimpleSolution.SharedApi.RepoImpl;

namespace SimpleSolution.VendorService.Repositories;

public class SubCategoryRepository : GenericRepo<SubCategory, long>
{
    public SubCategoryRepository(SetupContext context, ILogger<SubCategoryRepository> logger) : base(context, logger)
    {
    }
}


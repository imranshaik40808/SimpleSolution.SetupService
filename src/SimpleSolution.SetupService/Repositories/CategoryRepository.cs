using SimpleSolution.SetupService.Entities;
using SimpleSolution.SharedApi.RepoImpl;

namespace SimpleSolution.VendorService.Repositories;

public class CategoryRepository : GenericRepo<Category, long>
{
    public CategoryRepository(SetupContext context, ILogger<CategoryRepository> logger) : base(context, logger)
    {
    }
}


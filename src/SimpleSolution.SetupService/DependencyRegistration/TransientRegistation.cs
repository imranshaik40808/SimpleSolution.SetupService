using SimpleSolution.SetupService.Services;
using SimpleSolution.VendorService.Repositories;

namespace SimpleSolution.SetupService.DependencyRegistration;

public static class TransientRegistation
{
    public static void RegisterTransient(this IServiceCollection service)
    {
        service.AddTransient<VendorRepository>();
        service.AddTransient<CountryRepository>();
        service.AddTransient<StateRepository>();
        service.AddTransient<PinRepository>();
        service.AddTransient<CategoryRepository>();
        service.AddTransient<SubCategoryRepository>();
        service.AddTransient<AttributeInfoRepository>();
        service.AddTransient<AttributeRepository>();

        service.AddTransient<IVendorService, Services.VendorService>();
        service.AddTransient<ICountryService, CountryService>();
        service.AddTransient<IStateService, StateService>();
        service.AddTransient<IPinService, PinService>();
        service.AddTransient<ICategoryService, CategoryService>();
        service.AddTransient<ISubCategoryService, SubCategoryService>();
        service.AddTransient<IAttributeService, AttributeService>();
        service.AddTransient<IAttributeInfoService, AttributeInfoService>();
    }
}


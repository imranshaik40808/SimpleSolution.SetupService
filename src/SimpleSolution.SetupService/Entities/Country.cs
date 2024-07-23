using SimpleSolution.Models.Common;

namespace SimpleSolution.SetupService.Entities;
public class Country : BaseAuditModel<int>
{
    public string Name { get; set; }
}
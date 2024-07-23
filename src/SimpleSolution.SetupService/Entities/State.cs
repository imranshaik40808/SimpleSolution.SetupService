using SimpleSolution.Models.Common;

namespace SimpleSolution.SetupService.Entities;
public class State : BaseAuditModel<int>
{
    public string Name { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
}

using SimpleSolution.Models.Common;

namespace SimpleSolution.SetupService.Entities;
public class SubCategory : BaseAuditModel<int>
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public bool IsDisabled { get; set; }
}
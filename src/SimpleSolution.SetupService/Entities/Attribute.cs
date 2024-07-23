using SimpleSolution.Models.Common;

namespace SimpleSolution.SetupService.Entities;
public class Attribute : BaseAuditModel<long>
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public bool IsDisabled { get; set; }
}
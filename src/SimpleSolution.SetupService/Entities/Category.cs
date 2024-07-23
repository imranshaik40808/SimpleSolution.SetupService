
using SimpleSolution.Models.Common;

namespace SimpleSolution.SetupService.Entities;
public class Category : BaseAuditModel<int>
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public long VendorId { get; set; }
    public Vendor Vendor { get; set; }
    public bool IsDisabled { get; set; }
}
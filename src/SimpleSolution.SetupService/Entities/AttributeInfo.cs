using SimpleSolution.Models.Common;

namespace SimpleSolution.SetupService.Entities;
public class AttributeInfo : BaseAuditModel<long>
{
    public Attribute Attribute { get; set; }
    public Vendor Vendor { get; set; }
    public Category Category { get; set; }
    public SubCategory SubCategory { get; set; }
    public long AttributeId { get; set; }
    public long VendorId { get; set; }
    public int CategoryId { get; set; }
    public int SubCategoryId { get; set; }
    public string Icon { get; set; }
    public bool IsDisabled { get; set; }
}
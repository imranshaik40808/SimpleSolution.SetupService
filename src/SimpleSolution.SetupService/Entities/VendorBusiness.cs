using SimpleSolution.Models.Common;
using SimpleSolution.Models.Vendor;

namespace SimpleSolution.SetupService.Entities;
public class VendorBusiness : BaseAuditModel<long>
{

    public string BusinessName { get; set; }
    public BusinessType BusinessType { get; set; }
    public Term Term { get; set; }
    public bool IsActive { get; set; }
    public bool IsBlocked { get; set; }
    public string Remark { get; set; }
    public DateTime TermStartDate { get; set; }
    public DateTime TermExpiryDate { get; set; }
}
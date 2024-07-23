using SimpleSolution.Models.Common;

namespace SimpleSolution.SetupService.Entities;
public class VendorAddress : BaseAuditModel<long>
{
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLine3 { get; set; }
    public string PinId { get; set; }
    public string StateId { get; set; }
    public string CountryId { get; set; }

}
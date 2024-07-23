using SimpleSolution.Models.Common;

namespace SimpleSolution.SetupService.Entities;
public class Vendor : BaseAuditModel<long>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
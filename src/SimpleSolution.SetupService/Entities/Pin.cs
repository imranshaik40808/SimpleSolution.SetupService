using SimpleSolution.Models.Common;

namespace SimpleSolution.SetupService.Entities;
public class Pin : BaseAuditModel<int>
{
    public string Name { get; set; }
    public int StateId { get; set; }
    public State State { get; set; }
}
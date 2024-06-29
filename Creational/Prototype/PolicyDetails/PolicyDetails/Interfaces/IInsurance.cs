using PolicyDetails.Enums;

namespace PolicyDetails.Interfaces
{
    /// <summary>
    /// Defines the interface for insurance prototypes.
    /// </summary>
    public interface IInsurance
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        InsuranceType InsuranceType { get; set; }
        PolicyType PolicyType { get; set; }
        double Premium { get; set; }
        IInsurance Clone();
        void GetDetails();
    }
}

namespace InsuranceCoverDetails.Models
{
    /// <summary>
    /// Represents a home insurance policy.
    /// </summary>
    public class HomeInsurance : BaseModel
    {
        public string Address { get; set; }
        public double Value { get; set; }
        public bool FireCoverage { get; set; }
        public bool TheftCoverage { get; set; }
        public bool FloodCoverage { get; set; }

        public override string ToString()
        {
            return $"{InsuranceType} Home Insurance : \n" +
               $"  Address: {Address} \n" +
               $"  Value: {Value} \n" +
               $"  Fire Coverage: {FireCoverage} \n" +
               $"  Theft Coverage: {TheftCoverage} \n" +
               $"  Flood Coverage: {FloodCoverage} \n";
        }
    }
}

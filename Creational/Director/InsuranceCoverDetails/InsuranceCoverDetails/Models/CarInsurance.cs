namespace InsuranceCoverDetails.Models
{
    /// <summary>
    /// Represents a car insurance policy.
    /// </summary>
    public class CarInsurance : BaseModel
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public bool CollisionCoverage { get; set; }
        public bool ComprehensiveCoverage { get; set; }
        public double ExcessAmount { get; set; }

        public override string ToString()
        {
            return $"{InsuranceType} Car Insurance : \n" +
                $" Model: {Model} \n" +
                $" Year: {Year} \n" +
                $" Collision Coverage: {CollisionCoverage} \n" +
                $" Comprehensive Coverage: {ComprehensiveCoverage}  \n" +
                $" Excess Amount: {ExcessAmount} \n" ;
        }

    }
}

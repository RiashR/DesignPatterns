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
                $" CollisionCoverage: {CollisionCoverage} \n" +
                $" ComprehensiveCoverage: {ComprehensiveCoverage}  \n" +
                $" Deductible: {ExcessAmount} \n" ;
        }

    }
}

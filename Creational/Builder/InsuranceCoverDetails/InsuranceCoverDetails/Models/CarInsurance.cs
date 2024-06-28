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
            // ANSI escape codes for color
            string greenColor = "\u001b[32m";  // Green
            string redColor = "\u001b[31m";    // Red
            string resetColor = "\u001b[0m";   // Reset to default color

            // Determine color based on boolean values
            string collisionColor = CollisionCoverage ? greenColor : redColor;
            string comprehensiveColor = ComprehensiveCoverage ? greenColor : redColor;

            return $"{InsuranceType} Car Insurance:\n" +
                   $"  Model: {Model}\n" +
                   $"  Year: {Year}\n" +
                   $"  Collision Coverage: {collisionColor}{(CollisionCoverage ? "✓" : "✗")}{resetColor}\n" +
                   $"  Comprehensive Coverage: {comprehensiveColor}{(ComprehensiveCoverage ? "✓" : "✗")}{resetColor}\n" +
                   $"  Excess Amount: {ExcessAmount}\n";
        }

    }
}

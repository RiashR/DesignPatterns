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
            // ANSI escape codes for color
            string greenColor = "\u001b[32m";  // Green
            string redColor = "\u001b[31m";    // Red
            string resetColor = "\u001b[0m";   // Reset to default color

            // Determine color based on boolean values
            string fireColor = FireCoverage ? greenColor : redColor;
            string theftColor = TheftCoverage ? greenColor : redColor;
            string floodColor = FloodCoverage ? greenColor : redColor;

            return $"{InsuranceType} Home Insurance:\n" +
                   $"  Address: {Address}\n" +
                   $"  Value: {Value}\n" +
                   $"  Fire Coverage: {fireColor}{(FireCoverage ? "✓" : "✗")}{resetColor}\n" +
                   $"  Theft Coverage: {theftColor}{(TheftCoverage ? "✓" : "✗")}{resetColor}\n" +
                   $"  Flood Coverage: {floodColor}{(FloodCoverage ? "✓" : "✗")}{resetColor}\n";
        }
    }
}

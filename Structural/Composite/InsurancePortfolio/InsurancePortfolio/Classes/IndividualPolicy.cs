using InsurancePortfolio.Interfaces;

namespace InsurancePortfolio.Classes
{
    /// <summary>
    /// Represents an individual insurance policy. This is a leaf in the composite structure, 
    /// meaning it cannot contain other components.
    /// </summary>
    public class IndividualPolicy : IInsuranceComponent
    {
        /// <summary>
        /// Gets or sets the name of the individual policy.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualPolicy"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the individual policy (e.g., "Car Insurance").</param>
        public IndividualPolicy(string name) => Name = name;

        /// <summary>
        /// Displays the details of the individual policy by printing its name.
        /// </summary>
        /// <param name="indentLevel">The level of indentation for displaying details.</param>
        public void DisplayDetails(int indentLevel = 0)
        {
            Console.WriteLine(new string(' ', indentLevel * 2) + "- " + Name);
        }
    }
}

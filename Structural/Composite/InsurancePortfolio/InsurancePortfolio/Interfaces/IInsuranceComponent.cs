namespace InsurancePortfolio.Interfaces
{
    /// <summary>
    /// Represents a component in the composite pattern. It could be either a simple policy (Leaf) 
    /// or a composite policy package (Composite).
    /// </summary>
    public interface IInsuranceComponent
    {
        /// <summary>
        /// Gets or sets the name of the insurance component.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Displays the details of the insurance component.
        /// </summary>
        /// <param name="indentLevel">The level of indentation to visually represent hierarchy.</param>
        void DisplayDetails(int indentLevel = 0);
    }
}

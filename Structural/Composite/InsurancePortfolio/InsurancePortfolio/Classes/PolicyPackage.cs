using InsurancePortfolio.Interfaces;

namespace InsurancePortfolio.Classes
{
    /// <summary>
    /// Represents a package of insurance policies. This is a composite in the composite structure, 
    /// meaning it can contain other components (both individual policies and other packages).
    /// </summary>
    public class PolicyPackage : IInsuranceComponent
    {
        /// <summary>
        /// Gets or sets the name of the policy package.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Holds a list of child insurance components (both leaf and composite components).
        /// </summary>
        private List<IInsuranceComponent> _components = new List<IInsuranceComponent>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyPackage"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the policy package (e.g., "Home Insurance Package").</param>
        public PolicyPackage(string name) => Name = name;

        /// <summary>
        /// Displays the details of the package by printing its name and recursively displaying 
        /// the details of all child components.
        /// </summary>
        /// <param name="indentLevel">The level of indentation for displaying details.</param>
        public void DisplayDetails(int indentLevel = 0)
        {
            Console.WriteLine(new string(' ', indentLevel * 2) + "+ " + Name);

            foreach (var component in _components)
            {
                component.DisplayDetails(indentLevel + 1);
            }
        }

        /// <summary>
        /// Adds a child insurance component to the package.
        /// </summary>
        /// <param name="component">The insurance component to add (either a leaf or composite).</param>
        public void Add(IInsuranceComponent component)
        {
            _components.Add(component);
        }

        /// <summary>
        /// Removes a child insurance component from the package.
        /// </summary>
        /// <param name="component">The insurance component to remove.</param>
        public void Remove(IInsuranceComponent component)
        {
            _components.Remove(component);
        }
    }
}

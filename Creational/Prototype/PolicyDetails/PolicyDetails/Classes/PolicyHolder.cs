namespace PolicyDetails.Classes
{
    public class PolicyHolder
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public PolicyHolder(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

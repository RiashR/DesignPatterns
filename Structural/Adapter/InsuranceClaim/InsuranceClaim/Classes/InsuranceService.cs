namespace InsuranceClaim.Classes
{
    /// <summary>
    /// New insurance system with a different method for filing claims.
    /// </summary>
    public class InsuranceService
    {
        // Method specific to the new system with a different name and parameter type.
        public void ProcessInsuranceClaim(ClaimDetails claimDetails)
        {
            Console.WriteLine($"InsurancService: \n" +
                $"{claimDetails.InsuranceType} Insurance Claim submitted with description: {claimDetails.Description}, \n" +
                $"Amount: {claimDetails.Amount}, \n" +
                $"Date: {claimDetails.DateOfClaim.ToShortDateString()} \n");
        }
    }
}

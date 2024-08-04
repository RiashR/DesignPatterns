namespace InsuranceClaim.Classes
{
    /// <summary>
    /// Legacy insurance service with its own method for submitting claims.
    /// </summary>
    public class LegacyInsuranceService
    {
        public void SubmitClaim(ClaimDetails claimDetails)
        {
            Console.WriteLine($"Legacy Insurance Service: \n" +
                $"{claimDetails.InsuranceType} Insurance Claim submitted with description: {claimDetails.Description}, \n" +
                $"Amount: {claimDetails.Amount}, \n" +
                $"Date: {claimDetails.DateOfClaim.ToShortDateString()} \n");
        }
    }
}

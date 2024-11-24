using ClaimsStateProcessor.Classes;

namespace ClaimsStateProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var claim = new ClaimContext();

            Console.WriteLine("Initial State: Draft");
            claim.SubmitClaim();

            Console.WriteLine("\nReviewing the claim:");
            claim.ReviewClaim();

            Console.WriteLine("\nApproving the claim:");
            claim.ApproveClaim();

            Console.WriteLine("\nAttempting to reject an approved claim:");
            claim.RejectClaim();

            Console.WriteLine("\nAttempting further actions on an approved claim:");
            claim.SubmitClaim();
            claim.ReviewClaim();
            claim.ApproveClaim();

            Console.ReadKey();
        }
    }
}

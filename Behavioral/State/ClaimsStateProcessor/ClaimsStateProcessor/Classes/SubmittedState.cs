using ClaimsStateProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsStateProcessor.Classes
{
    /// <summary>
    /// Represents the state of a claim that has been submitted.
    /// </summary>
    public class SubmittedState : IClaimState
    {
        public void SubmitClaim(ClaimContext context)
        {
            Console.WriteLine("Claim is already submitted.");
        }

        public void ReviewClaim(ClaimContext context)
        {
            Console.WriteLine("Claim is now under review.");
            context.SetState(new ReviewState());
        }

        public void ApproveClaim(ClaimContext context)
        {
            Console.WriteLine("Cannot approve the claim. It must be reviewed first.");
        }

        public void RejectClaim(ClaimContext context)
        {
            Console.WriteLine("Cannot reject the claim. It must be reviewed first.");
        }
    }
}

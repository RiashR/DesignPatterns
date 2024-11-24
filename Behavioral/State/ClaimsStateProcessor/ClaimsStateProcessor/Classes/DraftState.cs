using ClaimsStateProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsStateProcessor.Classes
{
    /// <summary>
    /// Represents the initial draft state of a claim.
    /// </summary>
    public class DraftState : IClaimState
    {
        public void SubmitClaim(ClaimContext context)
        {
            Console.WriteLine("Claim has been submitted for review.");
            context.SetState(new SubmittedState());
        }

        public void ReviewClaim(ClaimContext context)
        {
            Console.WriteLine("Cannot review the claim. It is still in draft.");
        }

        public void ApproveClaim(ClaimContext context)
        {
            Console.WriteLine("Cannot approve the claim. It is still in draft.");
        }

        public void RejectClaim(ClaimContext context)
        {
            Console.WriteLine("Cannot reject the claim. It is still in draft.");
        }
    }
}

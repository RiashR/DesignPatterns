using ClaimsStateProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsStateProcessor.Classes
{
    /// <summary>
    /// Represents the state of a claim that is under review.
    /// </summary>
    public class ReviewState : IClaimState
    {
        public void SubmitClaim(ClaimContext context)
        {
            Console.WriteLine("Claim is already submitted and under review.");
        }

        public void ReviewClaim(ClaimContext context)
        {
            Console.WriteLine("Claim is already under review.");
        }

        public void ApproveClaim(ClaimContext context)
        {
            Console.WriteLine("Claim has been approved.");
            context.SetState(new ApprovedState());
        }

        public void RejectClaim(ClaimContext context)
        {
            Console.WriteLine("Claim has been rejected.");
            context.SetState(new RejectedState());
        }
    }
}

using ClaimsStateProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsStateProcessor.Classes
{
    /// <summary>
    /// Represents the state of a claim that has been approved.
    /// </summary>
    public class ApprovedState : IClaimState
    {
        public void SubmitClaim(ClaimContext context)
        {
            Console.WriteLine("Claim is already approved and cannot be resubmitted.");
        }

        public void ReviewClaim(ClaimContext context)
        {
            Console.WriteLine("Claim is already approved and cannot be reviewed again.");
        }

        public void ApproveClaim(ClaimContext context)
        {
            Console.WriteLine("Claim is already approved.");
        }

        public void RejectClaim(ClaimContext context)
        {
            Console.WriteLine("Claim is already approved and cannot be rejected.");
        }
    }
}

using ClaimsStateProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsStateProcessor.Classes
{
    /// <summary>
    /// Represents the context for an insurance claim.
    /// Manages the state of the claim and transitions between states.
    /// </summary>
    public class ClaimContext
    {

        private IClaimState _currentState;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimContext"/> class with the initial state as Draft.
        /// </summary>
        public ClaimContext()
        {
            _currentState = new DraftState();
        }

        /// <summary>
        /// Sets the current state of the claim.
        /// </summary>
        /// <param name="state">The new state to transition to.</param>
        public void SetState(IClaimState state)
        {
            _currentState = state;
        }

        /// <summary>
        /// Submits the claim.
        /// </summary>
        public void SubmitClaim() => _currentState.SubmitClaim(this);

        /// <summary>
        /// Reviews the claim.
        /// </summary>
        public void ReviewClaim() => _currentState.ReviewClaim(this);

        /// <summary>
        /// Approves the claim.
        /// </summary>
        public void ApproveClaim() => _currentState.ApproveClaim(this);

        /// <summary>
        /// Rejects the claim.
        /// </summary>
        public void RejectClaim() => _currentState.RejectClaim(this);
    }
}

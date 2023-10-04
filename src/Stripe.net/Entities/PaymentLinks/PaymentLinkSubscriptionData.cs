// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentLinkSubscriptionData : StripeEntity<PaymentLinkSubscriptionData>, IHasMetadata
    {
        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that will set
        /// metadata on [Subscriptions] (/docs/api/subscriptions) generated from this payment link.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time.
        /// </summary>
        [JsonProperty("trial_period_days")]
        public long? TrialPeriodDays { get; set; }
    }
}

// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceSubscriptionDetails : StripeEntity<InvoiceSubscriptionDetails>, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that will
        /// reflect the metadata of the subscription at the time of invoice creation. <em>Note: This
        /// attribute is populated only for invoices created on or after June 29, 2023.</em>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}

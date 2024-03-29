// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionPurchaseDetailsLodgingOptions : INestedOptions
    {
        /// <summary>
        /// The time of checking into the lodging.
        /// </summary>
        [JsonProperty("check_in_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CheckInAt { get; set; }

        /// <summary>
        /// The number of nights stayed at the lodging.
        /// </summary>
        [JsonProperty("nights")]
        public long? Nights { get; set; }
    }
}

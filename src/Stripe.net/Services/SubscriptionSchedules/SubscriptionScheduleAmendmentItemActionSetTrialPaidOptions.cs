// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentItemActionSetTrialPaidOptions : INestedOptions
    {
        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }
    }
}

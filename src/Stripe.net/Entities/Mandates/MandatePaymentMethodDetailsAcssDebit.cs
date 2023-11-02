// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsAcssDebit : StripeEntity<MandatePaymentMethodDetailsAcssDebit>
    {
        /// <summary>
        /// List of Stripe products where this mandate can be selected automatically.
        /// One of: <c>invoice</c>, or <c>subscription</c>.
        /// </summary>
        [JsonProperty("default_for")]
        public List<string> DefaultFor { get; set; }

        /// <summary>
        /// Description of the interval. Only required if the 'payment_schedule' parameter is
        /// 'interval' or 'combined'.
        /// </summary>
        [JsonProperty("interval_description")]
        public string IntervalDescription { get; set; }

        /// <summary>
        /// Payment schedule for the mandate.
        /// One of: <c>combined</c>, <c>interval</c>, or <c>sporadic</c>.
        /// </summary>
        [JsonProperty("payment_schedule")]
        public string PaymentSchedule { get; set; }

        /// <summary>
        /// Transaction type of the mandate.
        /// One of: <c>business</c>, or <c>personal</c>.
        /// </summary>
        [JsonProperty("transaction_type")]
        public string TransactionType { get; set; }
    }
}

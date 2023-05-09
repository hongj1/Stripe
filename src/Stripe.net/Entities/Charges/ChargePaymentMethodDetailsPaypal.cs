// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsPaypal : StripeEntity<ChargePaymentMethodDetailsPaypal>
    {
        /// <summary>
        /// Owner's email. Values are provided by PayPal directly (if supported) at the time of
        /// authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("payer_email")]
        public string PayerEmail { get; set; }

        /// <summary>
        /// PayPal account PayerID. This identifier uniquely identifies the PayPal customer.
        /// </summary>
        [JsonProperty("payer_id")]
        public string PayerId { get; set; }

        /// <summary>
        /// Owner's full name. Values provided by PayPal directly (if supported) at the time of
        /// authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// The level of protection offered as defined by PayPal Seller Protection for Merchants,
        /// for this transaction.
        /// </summary>
        [JsonProperty("seller_protection")]
        public ChargePaymentMethodDetailsPaypalSellerProtection SellerProtection { get; set; }

        /// <summary>
        /// The shipping address for the customer, as supplied by the merchant at the point of
        /// payment execution. This shipping address will not be updated if the merchant updates the
        /// shipping address on the PaymentIntent after the PaymentIntent was successfully
        /// confirmed.
        /// </summary>
        [JsonProperty("shipping")]
        public Address Shipping { get; set; }

        /// <summary>
        /// A unique ID generated by PayPal for this transaction.
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// The shipping address for the customer, as supplied by the merchant at the point of
        /// payment execution. This shipping address will not be updated if the merchant updates the
        /// shipping address on the PaymentIntent after the PaymentIntent was successfully
        /// confirmed.
        /// </summary>
        [JsonProperty("verified_address")]
        public Address VerifiedAddress { get; set; }

        /// <summary>
        /// Owner's verified email. Values are verified or provided by PayPal directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_email")]
        public string VerifiedEmail { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by PayPal directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}

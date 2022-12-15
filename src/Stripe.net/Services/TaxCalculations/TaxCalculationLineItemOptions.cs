// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxCalculationLineItemOptions : INestedOptions
    {
        /// <summary>
        /// A positive integer in cents representing the line item's total price. If
        /// <c>tax_behavior=inclusive</c>, then this amount includes taxes. Otherwise, taxes are
        /// calculated on top of this amount.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// If provided, the product's <c>tax_code</c> will be used as the line item's
        /// <c>tax_code</c>.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// The number of units of the item being purchased. The <c>amount</c> is a total amount for
        /// the whole line. Used to calculate the per-unit price, when required.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// A custom identifier for this line item. Must be unique across the line items in the
        /// calculation.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Specifies whether the <c>amount</c> includes taxes. If <c>tax_behavior=inclusive</c>,
        /// then the amount includes taxes.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID to use for this
        /// line item. If not provided, we will use the tax code from the provided <c>product</c>
        /// param. If neither <c>tax_code</c> or <c>product</c> is provided, we will use the default
        /// tax code from your Tax Settings.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }
    }
}

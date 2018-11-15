namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class WebhookEndpointTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/webhook_endpoints/we_123");
            var endpoint = JsonConvert.DeserializeObject<WebhookEndpoint>(json);
            Assert.NotNull(endpoint);
            Assert.IsType<WebhookEndpoint>(endpoint);
            Assert.NotNull(endpoint.Id);
            Assert.Equal("webhook_endpoint", endpoint.Object);
        }
    }
}

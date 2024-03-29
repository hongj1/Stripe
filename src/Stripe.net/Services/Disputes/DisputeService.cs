// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class DisputeService : Service<Dispute>,
        IListable<Dispute, DisputeListOptions>,
        IRetrievable<Dispute, DisputeGetOptions>,
        IUpdatable<Dispute, DisputeUpdateOptions>
    {
        public DisputeService()
            : base(null)
        {
        }

        public DisputeService(IStripeClient client)
            : base(client)
        {
        }

        public override string BasePath => "/v1/disputes";

        public virtual Dispute Close(string id, DisputeCloseOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Post, $"/v1/disputes/{id}/close", options, requestOptions);
        }

        public virtual Task<Dispute> CloseAsync(string id, DisputeCloseOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Post, $"/v1/disputes/{id}/close", options, requestOptions, cancellationToken);
        }

        public virtual Dispute Get(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Get, $"/v1/disputes/{id}", options, requestOptions);
        }

        public virtual Task<Dispute> GetAsync(string id, DisputeGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Get, $"/v1/disputes/{id}", options, requestOptions, cancellationToken);
        }

        public virtual StripeList<Dispute> List(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Dispute>>(HttpMethod.Get, $"/v1/disputes", options, requestOptions);
        }

        public virtual Task<StripeList<Dispute>> ListAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Dispute>>(HttpMethod.Get, $"/v1/disputes", options, requestOptions, cancellationToken);
        }

        public virtual IEnumerable<Dispute> ListAutoPaging(DisputeListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Dispute>($"/v1/disputes", options, requestOptions);
        }

        public virtual IAsyncEnumerable<Dispute> ListAutoPagingAsync(DisputeListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Dispute>($"/v1/disputes", options, requestOptions, cancellationToken);
        }

        public virtual Dispute Update(string id, DisputeUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Dispute>(HttpMethod.Post, $"/v1/disputes/{id}", options, requestOptions);
        }

        public virtual Task<Dispute> UpdateAsync(string id, DisputeUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Dispute>(HttpMethod.Post, $"/v1/disputes/{id}", options, requestOptions, cancellationToken);
        }
    }
}

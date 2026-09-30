using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Payrix.Core;
using Payrix.Core.Authentication;
using Payrix.Core.Exceptions;
using Payrix.Core.Models;
using Payrix.Core.Request;
using Payrix.Core.Response;
using Payrix.Errors;
using Payrix.Models;
using Payrix.Requests.PaymentUpdates;

namespace Payrix.Api;

/// <summary>
/// Payment Updates Holds information about the payment update - updating a payment method or account. The Payment Update will be related to a Payment, Subscription Token or Account, and owned by a Payment Update Group.
/// </summary>
public sealed class PaymentUpdates
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PaymentUpdates(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getPaymentUpdates
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentUpdatesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentUpdatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a PaymentUpdate.
    /// A PaymentUpdate holds information about the payment update. The paymentUpdate will be related to a payment, subscriptionToken or account, and owned by a paymentUpdateGroup.
    /// </remarks>
    public Task<PaymentUpdatesResponseResult> GetPaymentUpdates(GetPaymentUpdatesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paymentUpdates"),
            [],
            [
                new Param("page[number]", request.PageNumber),
                new Param("page[limit]", request.PageLimit),
                new Param("embed", request.Embed),
            ],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("search", request.Search),
                new HeaderParam("totals", request.Totals),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentUpdatesResponseResult>(),
            GetPaymentUpdatesError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getPaymentUpdatesId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentUpdatesResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentUpdatesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// _CONFLICT Query a Payment Update that holds information about the payment update, related to a payment, subscriptionToken or account, and owned by a paymentUpdateGroup.
    /// </remarks>
    public Task<PaymentUpdatesResponseResult> GetPaymentUpdatesId(GetPaymentUpdatesIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paymentUpdates/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentUpdatesResponseResult>(),
            GetPaymentUpdatesIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

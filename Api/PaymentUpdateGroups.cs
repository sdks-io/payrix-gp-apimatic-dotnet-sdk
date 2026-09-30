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
using Payrix.Requests.PaymentUpdateGroups;

namespace Payrix.Api;

/// <summary>
/// A collection of Payment Updates owned by the merchant's entity.
/// </summary>
public sealed class PaymentUpdateGroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PaymentUpdateGroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getPaymentUpdateGroups
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentUpdateGroupsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentUpdateGroupsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a PaymentUpdateGroup.
    /// A PaymentUpdateGroup has a collection of paymentUpdates owned by the merchant's entity.
    /// </remarks>
    public Task<PaymentUpdateGroupsResponseResult> GetPaymentUpdateGroups(GetPaymentUpdateGroupsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paymentUpdateGroups"),
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
            JsonResponse.Create<PaymentUpdateGroupsResponseResult>(),
            GetPaymentUpdateGroupsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getPaymentUpdateGroupsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentUpdateGroupsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentUpdateGroupsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Payment Update Group that has a collection of payment updates owned by the merchant's entity.
    /// </remarks>
    public Task<PaymentUpdateGroupsResponseResult> GetPaymentUpdateGroupsId(GetPaymentUpdateGroupsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paymentUpdateGroups/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentUpdateGroupsResponseResult>(),
            GetPaymentUpdateGroupsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

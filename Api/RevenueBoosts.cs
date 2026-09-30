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
using Payrix.Requests.RevenueBoosts;

namespace Payrix.Api;

/// <summary>
/// It captures the entities when they are enabled/disabled/re-enabled with networkPaymentManager
/// </summary>
public sealed class RevenueBoosts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal RevenueBoosts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getRevenueBoosts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevenueBoostsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetRevenueBoostsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query revenue boosts
    /// </remarks>
    public Task<RevenueBoostsResponseResult> GetRevenueBoosts(GetRevenueBoostsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/revenueBoosts"),
            [],
            [
                new Param("page[number]", request.PageNumber),
                new Param("page[limit]", request.PageLimit),
                new Param("embed", request.Embed),
            ],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("search", request.Search),
                new HeaderParam("totals", request.Totals),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RevenueBoostsResponseResult>(),
            GetRevenueBoostsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getRevenueBoostsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevenueBoostsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetRevenueBoostsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a RevenueBoost
    /// </remarks>
    public Task<RevenueBoostsResponseResult> GetRevenueBoostsId(GetRevenueBoostsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/revenueBoosts/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RevenueBoostsResponseResult>(),
            GetRevenueBoostsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

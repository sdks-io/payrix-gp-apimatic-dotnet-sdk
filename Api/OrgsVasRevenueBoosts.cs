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
using Payrix.Requests.OrgsVasRevenueBoosts;

namespace Payrix.Api;

/// <summary>
/// OrgsVasNetworkPaymentManager is a way to automatically enroll an entity associated with a specific org in the networkPaymentManager service.
/// </summary>
public sealed class OrgsVasRevenueBoosts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OrgsVasRevenueBoosts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getOrgsVASRevenueBoosts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgsVasRevenueBoostsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrgsVasRevenueBoostsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query all OrgsVasNetworkPaymentManager.
    /// </remarks>
    public Task<OrgsVasRevenueBoostsResponseResult> GetOrgsVasRevenueBoosts(GetOrgsVasRevenueBoostsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgsVASRevenueBoosts"),
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
            JsonResponse.Create<OrgsVasRevenueBoostsResponseResult>(),
            GetOrgsVasRevenueBoostsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getOrgsVASRevenueBoostsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OrgsVasRevenueBoostsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOrgsVasRevenueBoostsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a OrgsVasNetworkPaymentManager. an Entity.
    /// </remarks>
    public Task<OrgsVasRevenueBoostsResponseResult> GetOrgsVasRevenueBoostsId(GetOrgsVasRevenueBoostsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/orgsVASRevenueBoosts/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OrgsVasRevenueBoostsResponseResult>(),
            GetOrgsVasRevenueBoostsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

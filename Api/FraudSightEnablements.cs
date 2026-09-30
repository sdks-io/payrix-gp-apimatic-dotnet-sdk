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
using Payrix.Requests.FraudSightEnablements;

namespace Payrix.Api;

/// <summary>
/// Monitor and control entity-level access to the FraudSight service, a comprehensive fraud prevention solution for card-present and card-not-present transactions. Track when entities are enabled or disabled for FraudSight and maintain a complete audit trail for proactive fraud management.
/// </summary>
public sealed class FraudSightEnablements
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FraudSightEnablements(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getFraudSightEnablements
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FraudSightEnablementsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFraudSightEnablementsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieve FraudSight Enablements.
    /// </remarks>
    public Task<FraudSightEnablementsResponseResult> GetFraudSightEnablements(GetFraudSightEnablementsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/valueAddedServices/fraudSight"),
            [],
            [
                new Param("page[number]", request.PageNumber),
                new Param("page[limit]", request.PageLimit),
                new Param("embed", request.Embed),
            ],
            [
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("search", request.Search),
                new HeaderParam("totals", request.Totals),
            ],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FraudSightEnablementsResponseResult>(),
            GetFraudSightEnablementsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getFraudSightEnablementsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FraudSightEnablementsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFraudSightEnablementsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a fraudSightEnablements.
    /// </remarks>
    public Task<FraudSightEnablementsResponseResult> GetFraudSightEnablementsId(GetFraudSightEnablementsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/valueAddedServices/fraudSight/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FraudSightEnablementsResponseResult>(),
            GetFraudSightEnablementsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

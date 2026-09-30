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
using Payrix.Requests.FraudSightResults;

namespace Payrix.Api;

/// <summary>
/// Query fraudSightResults to retrieve information about fraud detection results from the FraudSight service.
/// </summary>
public sealed class FraudSightResults
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FraudSightResults(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getFraudSightResults
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FraudSightResultsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFraudSightResultsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a fraudSightResults.
    /// </remarks>
    public Task<FraudSightResultsResponseResult> GetFraudSightResults(GetFraudSightResultsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/valueAddedServices/fraudSightResults"),
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
            JsonResponse.Create<FraudSightResultsResponseResult>(),
            GetFraudSightResultsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getFraudSightResultsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FraudSightResultsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFraudSightResultsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a fraudSightResults.
    /// </remarks>
    public Task<FraudSightResultsResponseResult> GetFraudSightResultsId(GetFraudSightResultsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/valueAddedServices/fraudSightResults/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FraudSightResultsResponseResult>(),
            GetFraudSightResultsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

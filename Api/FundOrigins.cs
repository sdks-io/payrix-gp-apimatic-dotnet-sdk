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
using Payrix.Requests.FundOrigins;

namespace Payrix.Api;

/// <summary>
/// Each fundOrigin represents the sourced amounts of available funds, which are always traceable to a processor and merchant. This ensures accurate recording and compliance with funding rules. The table is used to determine how to cover negative amounts from fees, chargebacks, refunds, and other events. When disbursements are processed, the origins are recorded and reported to the processor as required.
/// </summary>
public sealed class FundOrigins
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal FundOrigins(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getFundOrigins
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FundOriginsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFundOriginsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query fundOrigins.
    /// </remarks>
    public Task<FundOriginsResponseResult> GetFundOrigins(GetFundOriginsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fundOrigins"),
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
            JsonResponse.Create<FundOriginsResponseResult>(),
            GetFundOriginsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getFundOriginsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FundOriginsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetFundOriginsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Fund Origin.
    /// </remarks>
    public Task<FundOriginsResponseResult> GetFundOriginsId(GetFundOriginsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/fundOrigins/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<FundOriginsResponseResult>(),
            GetFundOriginsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

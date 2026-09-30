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
using Payrix.Requests.ProfitShareResults;

namespace Payrix.Api;

/// <summary>
/// Profit Share Results Holds a message regarding a failed Profit Share process.
/// </summary>
public sealed class ProfitShareResults
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ProfitShareResults(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getProfitShareResults
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProfitShareResultsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetProfitShareResultsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a ProfitShareResult or Profit Share Result resource, which holds a message regarding a failed ProfitShare process.
    /// </remarks>
    public Task<ProfitShareResultsResponseResult> GetProfitShareResults(GetProfitShareResultsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/profitShareResults"),
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
            JsonResponse.Create<ProfitShareResultsResponseResult>(),
            GetProfitShareResultsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getProfitShareResultsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProfitShareResultsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetProfitShareResultsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a ProfitShareResult or Profit Share Result.
    /// </remarks>
    public Task<ProfitShareResultsResponseResult> GetProfitShareResultsId(GetProfitShareResultsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/profitShareResults/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ProfitShareResultsResponseResult>(),
            GetProfitShareResultsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

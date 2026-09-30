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
using Payrix.Requests.EmbeddedFinance;

namespace Payrix.Api;

/// <summary>
/// Embedded Finance stores information related to the activation of the resource for an entity. EmbeddedFinance's Valued Added Service provides access to new products and services related to Embedded Finance.
/// </summary>
public sealed class EmbeddedFinance
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal EmbeddedFinance(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getEmbeddedFinance
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EmbeddedFinanceResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEmbeddedFinanceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query embeddedFinance.
    /// </remarks>
    public Task<EmbeddedFinanceResponseResult> GetEmbeddedFinance(GetEmbeddedFinanceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/embeddedFinance"),
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
            JsonResponse.Create<EmbeddedFinanceResponseResult>(),
            GetEmbeddedFinanceError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getEmbeddedFinanceId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EmbeddedFinanceResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetEmbeddedFinanceIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a embeddedFinance.
    /// </remarks>
    public Task<EmbeddedFinanceResponseResult> GetEmbeddedFinanceId(GetEmbeddedFinanceIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/embeddedFinance/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<EmbeddedFinanceResponseResult>(),
            GetEmbeddedFinanceIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

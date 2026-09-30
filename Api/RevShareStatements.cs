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
using Payrix.Requests.RevShareStatements;

namespace Payrix.Api;

/// <summary>
/// Rev Share Statements table stores the final calculated revenue share entries that are billed to partners. It applies the revenue sharing schedule to a month's worth of transactions, resulting in the amount to be billed.
/// </summary>
public sealed class RevShareStatements
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal RevShareStatements(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getRevShareStatements
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevShareStatementsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetRevShareStatementsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query revShareStatements.
    /// </remarks>
    public Task<RevShareStatementsResponseResult> GetRevShareStatements(GetRevShareStatementsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/revShareStatements"),
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
            JsonResponse.Create<RevShareStatementsResponseResult>(),
            GetRevShareStatementsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getRevShareStatementsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RevShareStatementsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetRevShareStatementsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a revShareStatement.
    /// </remarks>
    public Task<RevShareStatementsResponseResult> GetRevShareStatementsId(GetRevShareStatementsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/revShareStatements/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<RevShareStatementsResponseResult>(),
            GetRevShareStatementsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

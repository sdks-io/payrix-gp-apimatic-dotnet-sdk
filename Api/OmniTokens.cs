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
using Payrix.Requests.OmniTokens;

namespace Payrix.Api;

/// <summary>
/// OmniTokens stores information related to the activation of the resource for an entity. OmniToken's Valued Added Service helps protect transactions and reduce transaction risk.
/// </summary>
public sealed class OmniTokens
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal OmniTokens(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// getOmniTokens
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OmniTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOmniTokensError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a omniTokens.
    /// </remarks>
    public Task<OmniTokensResponseResult> GetOmniTokens(GetOmniTokensRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/omniTokens"),
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
            JsonResponse.Create<OmniTokensResponseResult>(),
            GetOmniTokensError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getOmniTokensId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OmniTokensResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetOmniTokensIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a omniToken.
    /// </remarks>
    public Task<OmniTokensResponseResult> GetOmniTokensId(GetOmniTokensIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/omniTokens/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OmniTokensResponseResult>(),
            GetOmniTokensIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);
}

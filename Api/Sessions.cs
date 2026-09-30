using System;
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
using Payrix.Requests.Sessions;

namespace Payrix.Api;

/// <summary>
/// Resources that deals with secret (private) and public (publishable) user session keys for authentication in API interactions.
/// </summary>
public sealed class Sessions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Sessions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// deleteSessionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteSessionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Statement.
    /// A Statement resource represents the total collection of funds owed for a Billing period.
    /// </remarks>
    public Task<SessionsResponseResult> DeleteSessionsId(DeleteSessionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sessions/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SessionsResponseResult>(),
            DeleteSessionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getSessions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionsPostResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSessionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Query a Session.
    /// A Session represents a temporary method of authentication to the API. Each Session expires automatically after 30 minutes of inactivity.
    /// They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, Sessions are not permanent.
    /// </remarks>
    public Task<SessionsPostResponseResult> GetSessions(GetSessionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sessions"),
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
            JsonResponse.Create<SessionsPostResponseResult>(),
            GetSessionsError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// getSessionsId
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetSessionsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Querying a session resource represents a third-party session who interacts with the API, for example, a referral platform.
    /// </remarks>
    public Task<SessionsResponseResult> GetSessionsId(GetSessionsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sessions/{id}"),
            [new TemplateParam("id", request.Id)],
            [new Param("embed", request.Embed)],
            [new HeaderParam("token", request.Token), new HeaderParam("request-token", request.RequestToken)],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SessionsResponseResult>(),
            GetSessionsIdError.Response,
            [new AuthSchemeAny(_auth.ApiKey, _auth.SessionKey, _auth.TxnSessionKey)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// postSessions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionsResponseResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostSessionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a Session.
    /// A Session represents a temporary method of authentication to the API. Each Session expires automatically after 30 minutes of inactivity.
    /// They are similar to API Keys (/apikeys) in their capabilities and field structure - but unlike API Keys, Sessions are not permanent.
    /// </remarks>
    public Task<SessionsResponseResult> PostSessions(PostSessionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/sessions"),
            [],
            [],
            [
                new HeaderParam("token", request.Token),
                new HeaderParam("request-token", request.RequestToken),
                new HeaderParam("Idempotency-Key", Guid.NewGuid()),
            ],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SessionsResponseResult>(),
            PostSessionsError.Response,
            [
                new AuthSchemeAny(
                    _auth.ApiKey,
                    _auth.SessionKey,
                    _auth.TxnSessionKey,
                    new AuthSchemeAll(_auth.Username, _auth.Password)),
            ],
            requestOptions,
            cancellationToken);
}
